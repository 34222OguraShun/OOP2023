﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04 {
    class Program {
        static void Main(string[] args) {

#if NonArray
            var line = "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";


            //var words = line.Split(';','=');
            //var Novelist = "作家　：" + words[1];
            //var BestWork = "代表作：" + words[3];
            //var Born = "誕生日：" + words[5];
            //Console.WriteLine(Novelist);
            //Console.WriteLine(BestWork);
            //Console.WriteLine(Born);
#elif StringArray
            string[] lines = {
                "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886",
               "Novelist=夏目漱石;BestWork=坊ちゃん;Born=1867",
               "Novelist=太宰治;BestWork=人間失格;Born=1909",
               "Novelist=宮沢賢治;BestWork=銀河鉄道の夜;Born=1896",
            };
#endif

#if NonArray
            foreach (var pair in line.Split(';')) {
                var array = pair.Split('=');
                Console.WriteLine("{0}:{1}", array[0], array[1]);
            }

#elif StringArray


#endif

        }

     //   static string ToJapanese(string Key) {
     //       switch (Key) {
     //           case "Novelist":
     //               return "作家　：";
     //           case ";BestWork":
     //              return "代表作：";
     //        case "Born":
     //          return "誕生日：";
     //}
     //}
    }
}
