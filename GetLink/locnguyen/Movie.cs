using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GetLink.locnguyen
{
    public abstract class Movie
    {
        protected string GetResponseText(string url)
        {
            try
            {
                UriBuilder uriBuilder = new UriBuilder(url);
                var httpClient = new HttpClient();
                HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Get, uriBuilder.Uri.ToString());
                if (url.Contains("vuighe.net"))
                {
                    requestMessage.Headers.Add("X-Requested-With", "XMLHttpRequest");
                }
                requestMessage.Headers.Add("User-Agent",
                    "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/57.0.2987.74 Safari/537.36");
                requestMessage.Headers.Add("Referer", url);
                var response = httpClient.SendAsync(requestMessage).Result;
                var message = response.Content.ReadAsStringAsync().Result;
                return message;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public abstract IList<Episode> GetEpisodesId();
        public abstract IList<EpisodeLink> GetEpisodeLink(string id);
        public abstract string[,] SearchMovies(string keywords);
        public abstract string GetEpisodeInfo(string url);
    }
}
