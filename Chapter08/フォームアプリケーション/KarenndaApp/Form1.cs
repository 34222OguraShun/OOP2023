using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarenndaApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

       

        private void btDayCalc_Click(object sender, EventArgs e) {
            var dtb = dtpDate.Value;
            var now = DateTime.Now;

            

            tbMessage.Text = "入力した日にちから"+(now - dtb).Days +"日経過" + "  ";
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void bt_butan01_Click(object sender, EventArgs e) {
             int GetAge(DateTime birthday, DateTime targetDay) {
                var age = targetDay.Year - birthday.Year;
                if (targetDay < birthday.AddYears(age)) {
                    age--;
                }
                tbMessage.Text = age + "歳";
                return age;
                
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e) {
            tbMessage.Text = DateTime.Now.ToString("yyyy年MM月dd日 HH時mm分ss秒");
        }
    }
}
