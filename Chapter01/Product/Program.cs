using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductSample {
    class Program {
        static void Main(string[] args) {

            #region P26のサンプルプログラム
            Product karintou = new Product(123, "かりんとう", 180);
            Product Daihuku = new Product(235, "大福餅", 166);

            Console.WriteLine("かりんとうの税込価格:" + karintou.GetPriceIncloudingTax());
            Console.WriteLine("大福餅の税込価格:" + Daihuku.GetPriceIncloudingTax());
            #endregion

            //DateTime data = new DateTime(2023, 5, 8);
            DateTime date = DateTime.Today;  

            //10日後を求める
           DateTime daysAfter10 = date.AddDays(10);
            Console.WriteLine("今日の10日後は" + daysAfter10.Day + "日です。");

            //10日前を求める
            DateTime daysBefore10 = date.AddDays(-10);
            Console.WriteLine("今日の10日前は" + daysBefore10.Day + "日です。");




        }


    }
}
