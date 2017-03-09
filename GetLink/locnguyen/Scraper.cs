using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GetLink.locnguyen
{
    public class Scraper
    {
        public string Url;
        public Movie Instance;

        public Scraper(string url)
        {
            Url = url;
        }

        public Movie GetInstance()
        {
            if (Instance != null)
            {
                return Instance;
            }

            if (Url.Contains("phimmoi.net"))
            {
                Instance = new PhimMoi(Url);
            }

            if (Url.Contains("vuighe.net"))
            {
                Instance = new VuiGhe(Url);
            }

            return Instance;
        }

        public string GetEpisodeInfo(string url)
        {
            return GetInstance().GetEpisodeInfo(url);
        }

        public IList<EpisodeLink> GetPlaybackLinks(string episode_id)
        {
            return GetInstance().GetEpisodeLink(episode_id);
        }

        public IList<Episode> GetEpisodesId()
        {
            return GetInstance().GetEpisodesId();
        }

        public string[,] GetSearchResults(string keywords)
        {
            return GetInstance().SearchMovies(keywords);
        }
        
    }
}
