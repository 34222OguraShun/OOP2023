using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        Dictionary<string, string> favoriteDict = new Dictionary<string, string>();

        class FavoriteSet {
            public string Key { get; set; }
            public string Value { get; set; }

            public FavoriteSet(string Key, string Value) {
                this.Key = Key;
                this.Value = Value;
            }

            public override string ToString() {
                return Value;
            }
        }

        List<ItemData> ItemDatas = new List<ItemData>();
        private void btGet_Click(object sender, EventArgs e) {
            if (tbUrl.TextLength != 0){
                using (var wc = new WebClient()){

                    try{

                        var url = wc.OpenRead(tbUrl.Text);
                        XDocument xdoc = XDocument.Load(url);

                        ItemDatas.Clear();
                        lbRssTitle.Items.Clear();

                        ItemDatas = xdoc.Root.Descendants("item")
                                                .Select(x => new ItemData{
                                                    Title = (string)x.Element("title"),
                                                    Link = (string)x.Element("link"),
                                                }).ToList();

                        foreach (var node in ItemDatas){
                            lbRssTitle.Items.Add(node.Title);
                        }

                    }
                    catch (System.Net.WebException){
                        tbUrl.Text = string.Empty;
                    }
                }
            }
        }

        private void lbRssTitle_Click(object sender, EventArgs e) {
                wbBrowser.Navigate(ItemDatas[lbRssTitle.SelectedIndex].Link);
        }

        private void rbIT_CheckedChanged(object sender, EventArgs e) {
            tbUrl.Text = "https://news.yahoo.co.jp/rss/topics/it.xml";
        }

        private void rbEntertainment_CheckedChanged(object sender, EventArgs e) {
            tbUrl.Text = "https://news.yahoo.co.jp/rss/topics/entertainment.xml";
        }

        private void rbBusiness_CheckedChanged(object sender, EventArgs e) {
            tbUrl.Text = "https://news.yahoo.co.jp/rss/topics/business.xml";
        }

        private void rbSports_CheckedChanged(object sender, EventArgs e) {
            tbUrl.Text = "https://news.yahoo.co.jp/rss/topics/sports.xml";
        }

        private void btFavorite_Click(object sender, EventArgs e) {

            FavoriteSet favorite = new FavoriteSet(tbFavoriteURL.Text, tbFavoriteTitle.Text);
                cbFavoriteView.Items.Add(favorite);
                favoriteDict.Add(tbFavoriteURL.Text, tbFavoriteTitle.Text);
        }

        private void cbFavoriteView_SelectedIndexChanged(object sender, EventArgs e) {
            FavoriteSet favorite = (FavoriteSet)cbFavoriteView.SelectedItem;
            tbUrl.Text = favorite.Key.ToString();
        }
    }
}
