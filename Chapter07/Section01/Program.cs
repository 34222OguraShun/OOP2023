using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            #region 花の価格    
            //var flowerDict = new Dictionary<string, int>() {
            //    ["sunflower"] = 400,
            //    ["pansy"] = 300,
            //    ["tulip"] = 350,
            //["rose"] = 500,
            //["dahlia"] = 450,
            //};
            // flowerDict["morning glory"] = 250;//morning glory(あさがお)[250円]を追加


            //Console.WriteLine("ひまわりの価格は{0}円です。",flowerDict["sunflower"]);
            //Console.WriteLine("チューリップの価格は{0}円です。",flowerDict["tulip"]);
            //Console.WriteLine("あさがおの価格は{0}円です。", flowerDict["morning glory"]);
            #endregion

            var registration = new Dictionary<string, CityInfo>();

            string pref;
            string city;
            int population;

            Console.WriteLine("県庁所在地の登録");
            while (true) {

                Console.Write("県名：");
                pref = Console.ReadLine();
                if (pref == "999") break;


                Console.Write("所在地：");
                city = Console.ReadLine();

                Console.Write("人口：");
                population = int.Parse(Console.ReadLine());

                //重複処理
                if (registration.ContainsKey(pref)) {
                    Console.WriteLine("すでに登録されています。");
                    Console.WriteLine("上書きしますか？(y,n)：");
                    if (Console.ReadLine() =="y") {
                        registration[pref] = new CityInfo { City = city, Population = population, };
                    }
                }

                registration[pref] = new CityInfo { City = city, Population = population, };
            }
            Console.WriteLine("登録処理終了");

            Console.WriteLine("1：一覧表示　　2：県名指定");
            if (Console.ReadLine() == "1") {
                //一覧表示
                foreach (var item in registration.OrderByDescending(p =>p.Value.Population)){
                    Console.WriteLine("{0} 【{1}(人口：{2}人】", item.Key, item.Value.City,item.Value.Population);
                }

            }
            else {
                //県名を指定しての出力処理
                Console.Write("県名を入力：");
                var input = Console.ReadLine();
                Console.WriteLine("【{0}(人口：{1}人)  )", registration[input].City , registration[input].Population);
            }
            
        }
    }
    class CityInfo { 
        public string City { get; set; }//都市
        public int Population { get; set; }//人口
    }

}
