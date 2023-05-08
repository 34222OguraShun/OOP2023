using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductSample {
    class Program {
        static void Main(string[] args) {
            Product karintou = new Product(123, "かりんとう", 180);
            Console.WriteLine("かりんとうの税込価格:"+karintou.GetPriceIncloudingTax());

            Product Daihuku = new Product(235, "大福餅", 166);
            Console.WriteLine("大福餅の税込価格:" + Daihuku.GetPriceIncloudingTax());

        }
    }
}
