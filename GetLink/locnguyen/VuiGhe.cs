using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using HtmlDocument = System.Windows.Forms.HtmlDocument;

namespace GetLink.locnguyen
{
    public class VuiGhe : Movie
    {
        private string MovieId;
        private IList<Episode> Episodes;
        private IList<EpisodeLink> EpisodeLinks;
        private const string EPISODES = "episodes";
        private const string EPISODE_API = "http://vuighe.net/api/v2/films/";
        private const string EPISODE_API_QUERY = "/" + EPISODES + "?sort=name";
        private const string SEARCH_ADDRESS = "http://vuighe.net/tim-kiem/";

        public VuiGhe(string url)
        {
            GetMovieId(url);
        }

        public override string[,] SearchMovies(string keywords)
        {
            string searchAddress = SEARCH_ADDRESS + keywords;
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument document = web.Load(searchAddress);
            HtmlNode[] items = document.DocumentNode.SelectNodes("//div[@class='tray-item ']").ToArray();
            int lengthNode = items.Length;
            HtmlNode nodeSlug;
            HtmlNode nodeTitle;
            HtmlNode nodeEpisodes;
            if (lengthNode > 10)
            {
                lengthNode = 10;
            }
            string[,] ListItems = new string[lengthNode, 3];
            for (int i = 0; i < lengthNode; i++)
            {
                nodeSlug = items[i].SelectSingleNode(".//a");
                nodeTitle = items[i].SelectSingleNode(".//div[@class='tray-item-title']");
                nodeEpisodes = items[i].SelectSingleNode(".//div[@class='tray-film-update']");
                ListItems[i, 0] = nodeTitle.InnerText.Trim();
                ListItems[i, 1] = nodeEpisodes.InnerText.Trim();
                ListItems[i, 2] = nodeSlug.Attributes["href"].Value.Trim();
            }
            return ListItems;
        }

        public void GetMovieId(string url)
        {
            try
            {
                string source = GetResponseText(url);
                if (source != null)
                {
                    Regex regex = new Regex(@"data-id=""(\d+)""");
                    Match match = regex.Match(source);
                    MovieId = match.Groups[1].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message + "\nPlease contact with admin", @"Error");
            }
        }

        public override IList<Episode> GetEpisodesId()
        {
            try
            {
                string addressEpisode = EPISODE_API + MovieId + EPISODE_API_QUERY;
                JObject episodeData = JObject.Parse(GetResponseText(addressEpisode));
                var ep = episodeData["data"];
                IList<JToken> results = ep.Children().ToList();
                Episodes = new List<Episode>();

                foreach (JToken result in results)
                {
                    Episode episode = JsonConvert.DeserializeObject<Episode>(result.ToString());
                    Episodes.Add(episode);
                }
                return Episodes.Reverse().ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message + "\nPlease contact with admin", @"Error");
                return null;
            }
        }

        public override IList<EpisodeLink> GetEpisodeLink(string episodeId)
        {
            try
            {
                string addressEpisodeId = EPISODE_API + MovieId + "/" + EPISODES + "/" + episodeId;
                JObject episodeData = JObject.Parse(GetResponseText(addressEpisodeId));
                var ep = episodeData["sources"]["data"];
                IList<JToken> results = ep.Children().ToList();
                EpisodeLinks = new List<EpisodeLink>();
                foreach (JToken result in results)
                {
                    EpisodeLink link = JsonConvert.DeserializeObject<EpisodeLink>(result.ToString());
                    //                    link.id = episodeId;
                    EpisodeLinks.Add(link);
                }
                //            return JsonConvert.SerializeObject(EpisodeLinks);
                return EpisodeLinks;
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message + "\nPlease contact with admin", @"Error");
                return null;
            }
        }

        public override string GetEpisodeInfo(string url)
        {
            throw new NotImplementedException();
        }
    }
}