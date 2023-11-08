
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
            this.btFaboriteAdd = new System.Windows.Forms.Button();
            this.BtBusiness = new System.Windows.Forms.RadioButton();
            this.BtEntertainment = new System.Windows.Forms.RadioButton();
            this.BtSports = new System.Windows.Forms.RadioButton();
            this.BtIT = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbUrl
            // 
            this.tbUrl.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbUrl.Location = new System.Drawing.Point(32, 12);
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
            this.lbRssTitle.Location = new System.Drawing.Point(12, 164);
            this.lbRssTitle.Name = "lbRssTitle";
            this.lbRssTitle.Size = new System.Drawing.Size(641, 172);
            this.lbRssTitle.TabIndex = 2;
            // 
            // wbBrowser
            // 
            this.wbBrowser.Location = new System.Drawing.Point(12, 352);
            this.wbBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrowser.Name = "wbBrowser";
            this.wbBrowser.Size = new System.Drawing.Size(641, 291);
            this.wbBrowser.TabIndex = 3;
            // 
            // btFaboriteAdd
            // 
            this.btFaboriteAdd.Location = new System.Drawing.Point(578, 113);
            this.btFaboriteAdd.Name = "btFaboriteAdd";
            this.btFaboriteAdd.Size = new System.Drawing.Size(75, 44);
            this.btFaboriteAdd.TabIndex = 4;
            this.btFaboriteAdd.Text = "お気に入り登録";
            this.btFaboriteAdd.UseVisualStyleBackColor = true;
            this.btFaboriteAdd.Click += new System.EventHandler(this.btFaboriteAdd_Click);
            // 
            // BtBusiness
            // 
            this.BtBusiness.AutoSize = true;
            this.BtBusiness.Location = new System.Drawing.Point(81, 70);
            this.BtBusiness.Name = "BtBusiness";
            this.BtBusiness.Size = new System.Drawing.Size(47, 16);
            this.BtBusiness.TabIndex = 5;
            this.BtBusiness.TabStop = true;
            this.BtBusiness.Text = "経済";
            this.BtBusiness.UseVisualStyleBackColor = true;
            // 
            // BtEntertainment
            // 
            this.BtEntertainment.AutoSize = true;
            this.BtEntertainment.Location = new System.Drawing.Point(210, 70);
            this.BtEntertainment.Name = "BtEntertainment";
            this.BtEntertainment.Size = new System.Drawing.Size(57, 16);
            this.BtEntertainment.TabIndex = 6;
            this.BtEntertainment.TabStop = true;
            this.BtEntertainment.Text = "エンタメ";
            this.BtEntertainment.UseVisualStyleBackColor = true;
            // 
            // BtSports
            // 
            this.BtSports.AutoSize = true;
            this.BtSports.Location = new System.Drawing.Point(383, 70);
            this.BtSports.Name = "BtSports";
            this.BtSports.Size = new System.Drawing.Size(61, 16);
            this.BtSports.TabIndex = 7;
            this.BtSports.TabStop = true;
            this.BtSports.Text = "スポーツ";
            this.BtSports.UseVisualStyleBackColor = true;
            // 
            // BtIT
            // 
            this.BtIT.AutoSize = true;
            this.BtIT.Location = new System.Drawing.Point(554, 70);
            this.BtIT.Name = "BtIT";
            this.BtIT.Size = new System.Drawing.Size(33, 16);
            this.BtIT.TabIndex = 8;
            this.BtIT.TabStop = true;
            this.BtIT.Text = "IT";
            this.BtIT.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1.Location = new System.Drawing.Point(318, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(234, 31);
            this.textBox1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 691);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BtIT);
            this.Controls.Add(this.BtSports);
            this.Controls.Add(this.BtEntertainment);
            this.Controls.Add(this.BtBusiness);
            this.Controls.Add(this.btFaboriteAdd);
            this.Controls.Add(this.wbBrowser);
            this.Controls.Add(this.lbRssTitle);
            this.Controls.Add(this.btGet);
            this.Controls.Add(this.tbUrl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Button btGet;
        private System.Windows.Forms.ListBox lbRssTitle;
        private System.Windows.Forms.WebBrowser wbBrowser;
        private System.Windows.Forms.Button btFaboriteAdd;
        private System.Windows.Forms.RadioButton BtBusiness;
        private System.Windows.Forms.RadioButton BtEntertainment;
        private System.Windows.Forms.RadioButton BtSports;
        private System.Windows.Forms.RadioButton BtIT;
        private System.Windows.Forms.TextBox textBox1;
    }
}

