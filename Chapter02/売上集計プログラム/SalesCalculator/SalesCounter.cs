﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCalculator {
    class SalesCounter {

        private IEnumerable<Sale> _sales;

        //コンストラクタ
        public　SalesCounter(string filePath){
            _sales = ReadSales(filePath);
        }

        //店舗別の売り上げを求める
        public IDictionary<string, int> GetPerStoreSales() {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (Sale sale in _sales) {
                if (dict.ContainsKey(sale.ShopName))
                    dict[sale.ShopName] += sale.Amount;
                else
                    dict[sale.ShopName] = sale.Amount;
            }
            return dict;
        }


        //売り上げデータを読み込み、Saleオブジェクトのリストを返す
        private  static IEnumerable<Sale> ReadSales(string filePath) {
            List<Sale> sales = new List<Sale>();
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines) {        //すべての行から一行ずつ取り出す
                string[] items = line.Split(',');   //区切りで項目別に分ける
                Sale sale = new Sale {             //Saleインスタンス生成
                    ShopName = items[0],
                    ProductCategory = items[1],
                    Amount = int.Parse(items[2])
                };
                sales.Add(sale);//Saleインスタンスをコレクションに追加
            }
            return sales;
        }
    }
}
