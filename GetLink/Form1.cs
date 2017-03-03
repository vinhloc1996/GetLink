using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GetLink
{
    public partial class GetLink : Form
    {
        private string movie_id;
        public IList<Episode> Episodes;
        public IList<EpisodeLink> EpisodeLinks;
        private Button btn;

        public GetLink()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        public void GetEpisodesId()
        {
            string addressEpisode = "http://vuighe.net/api/v2/films/" + movie_id + "/episodes?sort=name";
            JObject episode_data = JObject.Parse(GetResponseText(addressEpisode));
            var ep = episode_data["data"];
            IList<JToken> Results = ep.Children().ToList();
            Episodes = new List<Episode>();
            foreach (JToken Result in Results)
            {
                Episode episode = JsonConvert.DeserializeObject<Episode>(Result.ToString());
                Episodes.Add(episode);
            }
//            return JsonConvert.SerializeObject(Episodes);
        }

        public void GetEpisodeLink(string episode_id)
        {
            string addressEpisodeId = "http://vuighe.net/api/v2/films/" + movie_id + "/episodes/" + episode_id;
            JObject episode_data = JObject.Parse(GetResponseText(addressEpisodeId));
            var ep = episode_data["sources"]["data"];
            IList<JToken> Results = ep.Children().ToList();
            EpisodeLinks = new List<EpisodeLink>();
            foreach (JToken Result in Results)
            {
                EpisodeLink link = JsonConvert.DeserializeObject<EpisodeLink>(Result.ToString());
                link.id = episode_id;
                EpisodeLinks.Add(link);
            }
//            return JsonConvert.SerializeObject(EpisodeLinks);
        }

        public string GetResponseText(string url)
        {
            var httpClient = new HttpClient();
            HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
            requestMessage.Headers.Add("X-Requested-With", "XMLHttpRequest");
            requestMessage.Headers.Add("User-Agent",
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/57.0.2987.74 Safari/537.36");
            requestMessage.Headers.Add("Referer", url);
            var response = httpClient.SendAsync(requestMessage).Result;
            var message = response.Content.ReadAsStringAsync().Result;
            return message;
        }

        public void GetMovieId(string url)
        {
            string source = GetResponseText(url);
            Regex regex = new Regex(@"data-id=""(\d+)""");
            Match match = regex.Match(source);
            movie_id = match.Groups[1].ToString();
//            return movie_id;
        }

        private void btnGetLink_Click(object sender, EventArgs e)
        {
            GetMovieId(txtLinksInput.Text.Trim());
            GetEpisodesId();
//            int i = 1;
            //            foreach (var episode in Episodes)
            //            {
            //                btn = new Button
            //                {
            //                    Text = @"Tap " + i,
            //                    AutoSize = true
            //                };
            //                flowpnl.Controls.Add(btn);
            //                i++;
            //            }
            GetEpisodeLink(Episodes[Episodes.Count - 1].id);
            textBox1.Text = EpisodeLinks[0].src;
            for (int i = 0; i < Episodes.Count; i++)
            {
                btn = new Button
                {
                    Text = @"Tap " + i,
                    AutoSize = true
                };
                flowpnl.Controls.Add(btn);
            }
        }
    }
}