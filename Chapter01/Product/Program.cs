using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductSample {
    class Program {
        static void Main(string[] args) {

           // #region P26のサンプルプログラム
           // Product karintou = new Product(123, "かりんとう", 180);
           // Product Daihuku = new Product(235, "大福餅", 166);

           // Console.WriteLine("かりんとうの税込価格:" + karintou.GetPriceIncloudingTax());
          //  Console.WriteLine("大福餅の税込価格:" + Daihuku.GetPriceIncloudingTax());
            //#endregion

            //DateTime data = new DateTime(2023, 5, 8);
            DateTime date = DateTime.Today;
            Console.WriteLine("今日の日付："+date.Year+"年"+date.Month+"月"+date.Day+"日");

            //10日後を求める
           DateTime daysAfter10 = date.AddDays(10);
            Console.WriteLine("10日後：" + daysAfter10.Year + "年" + daysAfter10.Month + "月" +daysAfter10.Day + "日");

            //10日前を求める
            DateTime daysBefore10 = date.AddDays(-10);
            Console.WriteLine("10日前："+ daysBefore10.Year + "年" + daysBefore10.Month + "月" + + daysBefore10.Day + "日");




        }


    }
}
