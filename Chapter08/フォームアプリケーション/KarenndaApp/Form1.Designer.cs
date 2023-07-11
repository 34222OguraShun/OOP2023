
namespace KarenndaApp {
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
            this.components = new System.ComponentModel.Container();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btDayCalc = new System.Windows.Forms.Button();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.te_nowTime = new System.Windows.Forms.TextBox();
            this.bt_butan01 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("ＭＳ ゴシック", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(124, 33);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 26);
            this.dtpDate.TabIndex = 1;
            // 
            // btDayCalc
            // 
            this.btDayCalc.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btDayCalc.Location = new System.Drawing.Point(70, 103);
            this.btDayCalc.Name = "btDayCalc";
            this.btDayCalc.Size = new System.Drawing.Size(104, 42);
            this.btDayCalc.TabIndex = 2;
            this.btDayCalc.Text = "日数計算";
            this.btDayCalc.UseVisualStyleBackColor = true;
            this.btDayCalc.Click += new System.EventHandler(this.btDayCalc_Click);
            // 
            // tbMessage
            // 
            this.tbMessage.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbMessage.Location = new System.Drawing.Point(225, 88);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(350, 172);
            this.tbMessage.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ＭＳ ゴシック", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "日付：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("ＭＳ ゴシック", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(22, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "現在時刻：";
            // 
            // te_nowTime
            // 
            this.te_nowTime.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.te_nowTime.Location = new System.Drawing.Point(170, 274);
            this.te_nowTime.Name = "te_nowTime";
            this.te_nowTime.Size = new System.Drawing.Size(254, 28);
            this.te_nowTime.TabIndex = 11;
            // 
            // bt_butan01
            // 
            this.bt_butan01.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bt_butan01.Location = new System.Drawing.Point(70, 173);
            this.bt_butan01.Name = "bt_butan01";
            this.bt_butan01.Size = new System.Drawing.Size(104, 46);
            this.bt_butan01.TabIndex = 12;
            this.bt_butan01.Text = "年齢";
            this.bt_butan01.UseVisualStyleBackColor = true;
            this.bt_butan01.Click += new System.EventHandler(this.bt_butan01_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 325);
            this.Controls.Add(this.bt_butan01);
            this.Controls.Add(this.te_nowTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.btDayCalc);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "カレンダーアプリ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btDayCalc;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox te_nowTime;
        private System.Windows.Forms.Button bt_butan01;
        private System.Windows.Forms.Timer timer1;
    }
}

