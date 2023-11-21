
namespace RssReader {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.btGet = new System.Windows.Forms.Button();
            this.lbRssTitle = new System.Windows.Forms.ListBox();
            this.wbBrowser = new System.Windows.Forms.WebBrowser();
            this.rbIT = new System.Windows.Forms.RadioButton();
            this.rbEntertainment = new System.Windows.Forms.RadioButton();
            this.rbSports = new System.Windows.Forms.RadioButton();
            this.rbBusiness = new System.Windows.Forms.RadioButton();
            this.btFavorite = new System.Windows.Forms.Button();
            this.tbFavoriteTitle = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelURL = new System.Windows.Forms.Label();
            this.tbFavoriteURL = new System.Windows.Forms.TextBox();
            this.cbFavoriteView = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbUrl
            // 
            this.tbUrl.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbUrl.Location = new System.Drawing.Point(12, 12);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(540, 31);
            this.tbUrl.TabIndex = 0;
            // 
            // btGet
            // 
            this.btGet.Location = new System.Drawing.Point(578, 12);
            this.btGet.Name = "btGet";
            this.btGet.Size = new System.Drawing.Size(75, 31);
            this.btGet.TabIndex = 1;
            this.btGet.Text = "取得";
            this.btGet.UseVisualStyleBackColor = true;
            this.btGet.Click += new System.EventHandler(this.btGet_Click);
            // 
            // lbRssTitle
            // 
            this.lbRssTitle.FormattingEnabled = true;
            this.lbRssTitle.ItemHeight = 12;
            this.lbRssTitle.Location = new System.Drawing.Point(30, 117);
            this.lbRssTitle.Name = "lbRssTitle";
            this.lbRssTitle.Size = new System.Drawing.Size(314, 256);
            this.lbRssTitle.TabIndex = 2;
            this.lbRssTitle.Click += new System.EventHandler(this.lbRssTitle_Click);
            // 
            // wbBrowser
            // 
            this.wbBrowser.Location = new System.Drawing.Point(30, 389);
            this.wbBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrowser.Name = "wbBrowser";
            this.wbBrowser.ScriptErrorsSuppressed = true;
            this.wbBrowser.Size = new System.Drawing.Size(646, 279);
            this.wbBrowser.TabIndex = 3;
            // 
            // rbIT
            // 
            this.rbIT.AutoSize = true;
            this.rbIT.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rbIT.Location = new System.Drawing.Point(529, 71);
            this.rbIT.Name = "rbIT";
            this.rbIT.Size = new System.Drawing.Size(48, 28);
            this.rbIT.TabIndex = 0;
            this.rbIT.TabStop = true;
            this.rbIT.Text = "IT";
            this.rbIT.UseVisualStyleBackColor = true;
            this.rbIT.CheckedChanged += new System.EventHandler(this.rbIT_CheckedChanged);
            // 
            // rbEntertainment
            // 
            this.rbEntertainment.AutoSize = true;
            this.rbEntertainment.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rbEntertainment.Location = new System.Drawing.Point(189, 71);
            this.rbEntertainment.Name = "rbEntertainment";
            this.rbEntertainment.Size = new System.Drawing.Size(98, 28);
            this.rbEntertainment.TabIndex = 1;
            this.rbEntertainment.TabStop = true;
            this.rbEntertainment.Text = "エンタメ";
            this.rbEntertainment.UseVisualStyleBackColor = true;
            this.rbEntertainment.CheckedChanged += new System.EventHandler(this.rbEntertainment_CheckedChanged);
            // 
            // rbSports
            // 
            this.rbSports.AutoSize = true;
            this.rbSports.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rbSports.Location = new System.Drawing.Point(376, 71);
            this.rbSports.Name = "rbSports";
            this.rbSports.Size = new System.Drawing.Size(104, 28);
            this.rbSports.TabIndex = 3;
            this.rbSports.TabStop = true;
            this.rbSports.Text = "スポーツ";
            this.rbSports.UseVisualStyleBackColor = true;
            this.rbSports.CheckedChanged += new System.EventHandler(this.rbSports_CheckedChanged);
            // 
            // rbBusiness
            // 
            this.rbBusiness.AutoSize = true;
            this.rbBusiness.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rbBusiness.Location = new System.Drawing.Point(48, 71);
            this.rbBusiness.Name = "rbBusiness";
            this.rbBusiness.Size = new System.Drawing.Size(76, 28);
            this.rbBusiness.TabIndex = 2;
            this.rbBusiness.TabStop = true;
            this.rbBusiness.Text = "経済";
            this.rbBusiness.UseVisualStyleBackColor = true;
            this.rbBusiness.CheckedChanged += new System.EventHandler(this.rbBusiness_CheckedChanged);
            // 
            // btFavorite
            // 
            this.btFavorite.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btFavorite.Location = new System.Drawing.Point(578, 329);
            this.btFavorite.Name = "btFavorite";
            this.btFavorite.Size = new System.Drawing.Size(98, 44);
            this.btFavorite.TabIndex = 6;
            this.btFavorite.Text = "お気に入り登録";
            this.btFavorite.UseVisualStyleBackColor = true;
            this.btFavorite.Click += new System.EventHandler(this.btFavorite_Click);
            // 
            // tbFavoriteTitle
            // 
            this.tbFavoriteTitle.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbFavoriteTitle.Location = new System.Drawing.Point(376, 172);
            this.tbFavoriteTitle.Name = "tbFavoriteTitle";
            this.tbFavoriteTitle.Size = new System.Drawing.Size(300, 31);
            this.tbFavoriteTitle.TabIndex = 9;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTitle.Location = new System.Drawing.Point(372, 135);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(81, 24);
            this.labelTitle.TabIndex = 10;
            this.labelTitle.Text = "タイトル";
            // 
            // labelURL
            // 
            this.labelURL.AutoSize = true;
            this.labelURL.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelURL.Location = new System.Drawing.Point(372, 224);
            this.labelURL.Name = "labelURL";
            this.labelURL.Size = new System.Drawing.Size(53, 24);
            this.labelURL.TabIndex = 11;
            this.labelURL.Text = "URL";
            // 
            // tbFavoriteURL
            // 
            this.tbFavoriteURL.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbFavoriteURL.Location = new System.Drawing.Point(376, 260);
            this.tbFavoriteURL.Name = "tbFavoriteURL";
            this.tbFavoriteURL.Size = new System.Drawing.Size(300, 31);
            this.tbFavoriteURL.TabIndex = 12;
            // 
            // cbFavoriteView
            // 
            this.cbFavoriteView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFavoriteView.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbFavoriteView.FormattingEnabled = true;
            this.cbFavoriteView.Location = new System.Drawing.Point(379, 343);
            this.cbFavoriteView.Name = "cbFavoriteView";
            this.cbFavoriteView.Size = new System.Drawing.Size(176, 24);
            this.cbFavoriteView.TabIndex = 13;
            this.cbFavoriteView.SelectedIndexChanged += new System.EventHandler(this.cbFavoriteView_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(375, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "登録リスト";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 691);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbIT);
            this.Controls.Add(this.rbEntertainment);
            this.Controls.Add(this.rbBusiness);
            this.Controls.Add(this.rbSports);
            this.Controls.Add(this.cbFavoriteView);
            this.Controls.Add(this.tbFavoriteURL);
            this.Controls.Add(this.labelURL);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.tbFavoriteTitle);
            this.Controls.Add(this.btFavorite);
            this.Controls.Add(this.wbBrowser);
            this.Controls.Add(this.lbRssTitle);
            this.Controls.Add(this.btGet);
            this.Controls.Add(this.tbUrl);
            this.Name = "Form1";
            this.Text = "RssReder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Button btGet;
        private System.Windows.Forms.ListBox lbRssTitle;
        private System.Windows.Forms.WebBrowser wbBrowser;
        private System.Windows.Forms.RadioButton rbIT;
        private System.Windows.Forms.RadioButton rbEntertainment;
        private System.Windows.Forms.RadioButton rbSports;
        private System.Windows.Forms.RadioButton rbBusiness;
        private System.Windows.Forms.Button btFavorite;
        private System.Windows.Forms.TextBox tbFavoriteTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelURL;
        private System.Windows.Forms.TextBox tbFavoriteURL;
        private System.Windows.Forms.ComboBox cbFavoriteView;
        private System.Windows.Forms.Label label1;
    }
}

