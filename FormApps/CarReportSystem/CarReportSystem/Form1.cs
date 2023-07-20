using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class Form1 : Form {
        //管理用データ
        BindingList<CarReport> CarReports = new BindingList<CarReport>();
        
        public Form1() {
            InitializeComponent();
            dgvCarReports.DataSource = CarReports;
        }

        //ステータスラベルの表示、非表示
        private void statasLabelDisp(string msg) {
            tsInfoText.Text = msg;
        }



        //追加ボタンがクリックされた時のイベントハンドラー
        private void btAddReport_Click(object sender, EventArgs e) {
            if (cbAuthor.Text == "") {
                tsInfoText.Text = "記録者を入力してください";
                return;
            }
            else if (cbCarName.Text == "") {
                tsInfoText.Text = "車名を入力してください";
                return;
            }
            else {
                tsInfoText.Text = "";
            }

            if (tsInfoText.Text == "") {
                var carReport = new CarReport                            //Saleインスタンスを生成
                {
                    Date = dtpDate.Value,
                    Author = cbAuthor.Text,
                    Maker = getSelectedMaker(),
                    CarName = cbCarName.Text,
                    Report = tbReport.Text,
                    CarImage = pbCarImage.Image,
                };
                CarReports.Add(carReport);
                btModifyReport.Enabled = true;
                btDeleteReport.Enabled = true;
                cbAuthor.Text = "";   cbCarName.Text = "";


            }

        }

            

        //ラジオボタンで選択されているメーカーを返却
        private CarReport.MakerGroup getSelectedMaker() {
            foreach (var item in gbMaker.Controls) {
                if (((RadioButton)item).Checked) {
                    return (CarReport.MakerGroup)int.Parse(((RadioButton)item).Tag.ToString());
                }
            }
            return CarReport.MakerGroup.その他;
        }

        //指定したメーカーのラジオボタンをセット
        private void setSelectedMaker(CarReport.MakerGroup makerGroup) {
            switch (makerGroup) {
                case CarReport.MakerGroup.トヨタ:
                    rbToyota.Checked = true;
                    break;
                case CarReport.MakerGroup.日産:
                    rbNissan.Checked = true;
                    break;
                case CarReport.MakerGroup.ホンダ:
                    rbHonda.Checked = true;
                    break;
                case CarReport.MakerGroup.スバル:
                    rbSubaru.Checked = true;
                    break;
                case CarReport.MakerGroup.スズキ:
                    rbSuzuki.Checked = true;
                    break;
                case CarReport.MakerGroup.ダイハツ:
                    rbDaihatsu.Checked = true;
                    break;
                case CarReport.MakerGroup.輸入車:
                    rbImported.Checked = true;
                    break;
                case CarReport.MakerGroup.その他:
                    rbOther.Checked = true;
                    break;
            }
        }

        private void btImageOpen_Click(object sender, EventArgs e) {
            ofdImageFileOpen.ShowDialog();
            pbCarImage.Image = Image.FromFile(ofdImageFileOpen.FileName);
        }

        private void Form1_Load(object sender, EventArgs e) {
            dgvCarReports.Columns[5].Visible = false;   //画像項目非表示
                btModifyReport.Enabled = false; //マスクする
                btDeleteReport.Enabled = false; //マスクする
            }

        //削除ボタンイベントハンドラ
        private void btDeleteReport_Click(object sender, EventArgs e) {
            if (dgvCarReports.Rows.Count == 0) {
                btModifyReport.Enabled = false;
                btDeleteReport.Enabled = false;
            }
            else {
                CarReports.RemoveAt(dgvCarReports.CurrentRow.Index);
            }
        }

        //レコードの選択時
        private void dgvCarReports_Click(object sender, EventArgs e) {
            dtpDate.Value = (DateTime)dgvCarReports.CurrentRow.Cells[0].Value;
            cbAuthor.Text = dgvCarReports.CurrentRow.Cells[1].Value.ToString();
            setSelectedMaker((CarReport.MakerGroup)dgvCarReports.CurrentRow.Cells[2].Value);
            cbCarName.Text = dgvCarReports.CurrentRow.Cells[3].Value.ToString();
            tbReport.Text = dgvCarReports.CurrentRow.Cells[4].Value.ToString();
            pbCarImage.Image = (Image)dgvCarReports.CurrentRow.Cells[5].Value;
        }
        //修正ボタンイベントハンドラ
        private void btModifyReport_Click(object sender, EventArgs e) {
            if (dgvCarReports.Rows.Count != 0) {
                CarReports[dgvCarReports.CurrentRow.Index].Date = dtpDate.Value;
                CarReports[dgvCarReports.CurrentRow.Index].Author = cbAuthor.Text;
                CarReports[dgvCarReports.CurrentRow.Index].Maker = getSelectedMaker();
                CarReports[dgvCarReports.CurrentRow.Index].CarName = cbCarName.Text;
                CarReports[dgvCarReports.CurrentRow.Index].Report = tbReport.Text;
                dgvCarReports.Refresh();    //一覧更新
            }
        }
        
       
    }
}
