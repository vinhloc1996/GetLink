using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetLink.locnguyen
{
    public class PhimMoi : Movie
    {
        private string Url;
        public PhimMoi(string url)
        {
            Url = url;
        }

        public string GetReplacedJson(string json)
        {
            return json.Replace(@"""url""", "src").Replace(@"""resolution""", "quality");
        }

        public override IList<Episode> GetEpisodesId()
        {
            throw new NotImplementedException();
        }

        public override IList<EpisodeLink> GetEpisodeLink(string id)
        {
            throw new NotImplementedException();
        }

        public string DecoderUrl(string url, string password)
        {
            return GibberishAes.OpenSSLDecrypt(url, password);
        }

        public override string GetEpisodeInfo(string url)
        {
            if (!url.Contains("xem-phim.html"))
            {
                url += "/xem-phim.html";
            }
            string source = GetResponseText(url);
            Regex regex = new Regex("(http://www.phimmoi.net/episodeinfo.*?)\" onload");
            Match match = regex.Match(source);
            return match.Groups[1].ToString().Replace("javascript", "json");
        }

        public override string[,] SearchMovies(string keywords)
        {
            throw new NotImplementedException();
        }
    }
}