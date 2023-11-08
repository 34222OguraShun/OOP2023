﻿using System;
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
        
        //取得データ保存用
        List<ItemData> ItemDatas = new List<ItemData>();
        
        public Form1() {
            InitializeComponent();
        }

        private void btGet_Click(object sender, EventArgs e) {
            if (tbUrl.Text == "") {
                return;
            }

            using (var wc = new WebClient()) {
                var url = wc.OpenRead(tbUrl.Text);
                XDocument xdoc = XDocument.Load(url);

                ItemDatas = xdoc.Root.Descendants("item")
                                        .Select(x => new ItemData {
                                            Title = (string)x.Element("title"),
                                            Link = (string)x.Element("link"),
                                        }).ToList();


                foreach (var node in ItemDatas) {
                    lbRssTitle.Items.Add(node.Title);
                }
            }
        }

        private void lbRssTitle_Click(object sender, EventArgs e) {
            wbBrowser.Navigate(ItemDatas[lbRssTitle.SelectedIndex].Link);
        }

        private void BtBusiness_CheckedChanged(object sender, EventArgs e) {
            tbUrl.Text = "https://news.yahoo.co.jp/rss/topics/business.xml";
        }

        private void BtEntertainment_CheckedChanged(object sender, EventArgs e) {
            tbUrl.Text = "https://news.yahoo.co.jp/rss/topics/entertainment.xml";
        }

        private void BtSports_CheckedChanged(object sender, EventArgs e) {
            tbUrl.Text = "https://news.yahoo.co.jp/rss/topics/sports.xml";
        }

        private void BtIT_CheckedChanged(object sender, EventArgs e) {
            tbUrl.Text = "https://news.yahoo.co.jp/rss/topics/it.xml";
        }

        private void btFaboriteAdd_Click(object sender, EventArgs e) {

        }
    }
}