﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using HtmlAgilityPack;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace GetLink
{
    public partial class GetLink : Form
    {
        private string _movieId;
        public IList<Episode> Episodes;
        public IList<EpisodeLink> EpisodeLinks;
        private string[,] _listItems;

        public GetLink()
        {
            InitializeComponent();
            MaximizeBox = false;
            lboxEpisodes.SelectionMode = SelectionMode.One;
            GenerateColumnsListView();
            txtSearchBox.Focus();
        }

        private void GenerateColumnsListView()
        {
            lviewResults.Columns.Add("Title", 201);
            lviewResults.Columns.Add("Episodes", 100);
            lviewResults.Columns.Add("Slug", 0);
            //            lviewResults.Columns[2].Width = 0;
        }

        private void GenerateItemsListView()
        {
            ListViewItem item;
            for (int i = 0; i < _listItems.GetLength(0); i++)
            {
                item = new ListViewItem();
                item.Text = _listItems[i, 0];
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = _listItems[i, 1] });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = _listItems[i, 2] });
                lviewResults.Items.Add(item);
            }
        }

        public void GetEpisodesId(string episodeId)
        {
            try
            {
                Regex isNummeric = new Regex(@"\d");
                string addressEpisode = "http://vuighe.net/api/v2/films/" + _movieId + "/episodes?sort=name";
                JObject episodeData = JObject.Parse(GetResponseText(addressEpisode));
                var ep = episodeData["data"];
                IList<JToken> results = ep.Children().ToList();
                Episodes = new List<Episode>();

                if (string.IsNullOrEmpty(episodeId))
                {
                    foreach (JToken result in results)
                    {
                        Episode episode = JsonConvert.DeserializeObject<Episode>(result.ToString());
                        Episodes.Add(episode);
                    }
                }
                else
                {
                    if (isNummeric.IsMatch(episodeId))
                    {
                        int tap = int.Parse(episodeId);
                        if (tap >= results.Count && tap >= 0)
                        {
                            MessageBox.Show(@"Input episode must be smaller or equal with the episode of movie");
                        }
                        else
                        {
                            Episode episode = JsonConvert.DeserializeObject<Episode>(results[tap].ToString());
                            Episodes.Add(episode);
                        }
                    }
                    else
                    {
                        MessageBox.Show(@"Invalid episode");
                    }
                }
                //            return JsonConvert.SerializeObject(Episodes);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message + "\nPlease contact with admin", @"Error");
            }
        }

        public void GetEpisodeLink(string episodeId)
        {
            try
            {
                string addressEpisodeId = "http://vuighe.net/api/v2/films/" + _movieId + "/episodes/" + episodeId;
                JObject episodeData = JObject.Parse(GetResponseText(addressEpisodeId));
                var ep = episodeData["sources"]["data"];
                IList<JToken> results = ep.Children().ToList();
                EpisodeLinks = new List<EpisodeLink>();
                foreach (JToken result in results)
                {
                    EpisodeLink link = JsonConvert.DeserializeObject<EpisodeLink>(result.ToString());
                    link.id = episodeId;
                    EpisodeLinks.Add(link);
                }
                //            return JsonConvert.SerializeObject(EpisodeLinks);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message + "\nPlease contact with admin", @"Error");
            }
        }

        public string GetResponseText(string url)
        {
            try
            {
                UriBuilder uriBuilder = new UriBuilder(url);
                var httpClient = new HttpClient();
                HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Get, uriBuilder.Uri.ToString());
                requestMessage.Headers.Add("X-Requested-With", "XMLHttpRequest");
                requestMessage.Headers.Add("User-Agent",
                    "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/57.0.2987.74 Safari/537.36");
                requestMessage.Headers.Add("Referer", url);
                var response = httpClient.SendAsync(requestMessage).Result;
                var message = response.Content.ReadAsStringAsync().Result;
                return message;
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message + "\nPlease contact with admin", @"Error");
                return null;
            }
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
                    _movieId = match.Groups[1].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message + "\nPlease contact with admin", @"Error");
            }
        }

        private void btnGetEpisode_Click(object sender, EventArgs e)
        {
            try
            {
                string link = txtLinksInput.Text.Trim();
                string episode = txtEpisode.Text.Trim();
                if (link.Length > 0)
                {
                    GetMovieId(link);
                    if (!string.IsNullOrEmpty(episode))
                    {
                        cbbQualities.DataSource = null;
                        cbbQualities.Items.Clear();
                        GetEpisodesId(episode);
                        txtEpisode.Text = "";
                        txtEpisode.Focus();
                        lboxEpisodes.Items.Clear();
                        for (int i = 0; i < Episodes.Count; i++)
                        {
                            lboxEpisodes.Items.Add(Episodes[i].full_name);
                        }
                    }
                    else
                    {
                        MessageBox.Show(@"Please choose specified episode");
                    }
                }
                else
                {
                    MessageBox.Show(@"Link cannot be nulled");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message + "\nPlease contact with admin", @"Error");
            }
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            try
            {
                int getEpisode = lboxEpisodes.SelectedIndex;
                if (getEpisode == -1)
                {
                    MessageBox.Show(@"Please select one episode before continues");
                }
                else
                {
                    GetEpisodeLink(Episodes[getEpisode].id);
                    Dictionary<string, string> source = new Dictionary<string, string>();

                    for (int i = 0; i < EpisodeLinks.Count; i++)
                    {
                        source.Add(EpisodeLinks[i].quality, EpisodeLinks[i].src);
                    }
                    cbbQualities.DataSource = new BindingSource(source, null);
                    cbbQualities.DisplayMember = "Key";
                    cbbQualities.ValueMember = "Value";
                    cbbQualities.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message + "\nPlease contact with admin", @"Error");
            }
        }

        private void btnWatch_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbbQualities.SelectedIndex == -1)
                {
                    MessageBox.Show(@"Please choose episode and quality before playing");
                }
                else
                {
                    var form = new player(((KeyValuePair<string, string>) cbbQualities.SelectedItem).Value);
                    form.ShowDialog();
                    //            MessageBox.Show(((KeyValuePair<string, string>)cbbQualities.SelectedItem).Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message + "\nPlease contact with admin", @"Error");
            }
        }

        private void btnFinalEpisode_Click(object sender, EventArgs e)
        {
            try
            {
                string link = txtLinksInput.Text.Trim();
                if (link.Length > 0)
                {
                    cbbQualities.DataSource = null;
                    cbbQualities.Items.Clear();
                    GetMovieId(link);
                    GetEpisodesId(txtEpisode.Text.Trim());
                    lboxEpisodes.Items.Clear();
                    lboxEpisodes.Items.Add(Episodes[Episodes.Count - 1].full_name);
                }
                else
                {
                    MessageBox.Show(@"Link cannot be nulled");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message + "\nPlease contact with admin", @"Error");
            }
        }

        private void btnGetAllLinks_Click(object sender, EventArgs e)
        {
            try
            {
                string link = txtLinksInput.Text.Trim();
                if (link.Length > 0)
                {
                    cbbQualities.DataSource = null;
                    cbbQualities.Items.Clear();
                    GetMovieId(link);
                    GetEpisodesId(null);
                    lboxEpisodes.Items.Clear();
                    for (int i = 0; i < Episodes.Count; i++)
                    {
                        lboxEpisodes.Items.Add(Episodes[i].full_name);
                    }
                }
                else
                {
                    MessageBox.Show(@"Link cannot be nulled");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message + "\nPlease contact with admin", @"Error");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keywords = txtSearchBox.Text.Trim();
            try
            {
                if (keywords.Length > 0)
                {
                    lviewResults.Items.Clear();
                    string searchAddress = "http://vuighe.net/tim-kiem/" + keywords + "";
                    HtmlWeb web = new HtmlWeb();
                    HtmlDocument document = web.Load(searchAddress);
                    HtmlNode[] items = document.DocumentNode.SelectNodes("//div[@class='tray-item ']").ToArray();
                    int lengthNode = items.Length;
                    HtmlNode nodeSlug;
                    HtmlNode nodeTitle;
                    HtmlNode nodeEpisodes;
                    if (lengthNode > 10)
                    {
                        lengthNode = 10;
                    }
                    _listItems = new string[lengthNode, 3];
                    for (int i = 0; i < lengthNode; i++)
                    {
                        nodeSlug = items[i].SelectSingleNode(".//a");
                        nodeTitle = items[i].SelectSingleNode(".//div[@class='tray-item-title']");
                        nodeEpisodes = items[i].SelectSingleNode(".//div[@class='tray-film-update']");
                        //                    lviewResults.Items.Add(nodeTitle.InnerText.Trim(), nodeEpisodes.InnerText.Trim(),
                        //                        nodeSlug.Attributes["href"].Value.Trim());
                        _listItems[i, 0] = nodeTitle.InnerText.Trim();
                        _listItems[i, 1] = nodeEpisodes.InnerText.Trim();
                        _listItems[i, 2] = nodeSlug.Attributes["href"].Value.Trim();
                        //                    MessageBox.Show("Title: " + nodeTitle.InnerText + "\nSlug " + nodeSlug.Attributes["href"].Value +
                        //                                    "\nEpisodes: " + nodeEpisodes.InnerText);
                    }
                    GenerateItemsListView();
                }
                else
                {
                    MessageBox.Show(@"Please input the keywords");
                }
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(@"Cannot find result with keywork '" + keywords + "'");
//                MessageBox.Show(ex.StackTrace);
            }
        }

        private void lviewResults_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lboxEpisodes.Items.Clear();
            txtLinksInput.Text = @"http://vuighe.net" + lviewResults.SelectedItems[0].SubItems[2].Text;
            txtLinksInput.Focus();
//            MessageBox.Show(lviewResults.SelectedItems[0].SubItems[2].Text);
        }

        private void txtSearchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnSearch.PerformClick();
            }
        }

        private void txtLinksInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnGetAllLinks.PerformClick();
            }
        }

        private void txtEpisode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnGetEpisode.PerformClick();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            int length = lboxEpisodes.Items.Count;
            if (length > 0)
            {
                string path = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\..\"));
                string links = "";
                for (int i = 0; i < length; i++)
                {
                    GetEpisodeLink(Episodes[i].id);
                    links += EpisodeLinks[0].src + "\n";
                }
                File.WriteAllText(path+"links.txt", links);
                MessageBox.Show(@"Write file successful!");
                txtLinksInput.Text = "";
                txtSearchBox.Focus();
                lboxEpisodes.Items.Clear();
            }
            else
            {
                MessageBox.Show(@"Get some episode before export links");
            }
        }
    }
}