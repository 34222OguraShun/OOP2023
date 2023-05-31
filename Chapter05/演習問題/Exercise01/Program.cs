using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            Console.Write("文字列1:");
            var s1 = Console.ReadLine();

            Console.Write("文字列2:");
            var s2 = Console.ReadLine();

            if (string.Compare(s1, s2, ignoreCase: true) == 0) {
                Console.WriteLine("同じ文字列");
            }
            else {
                Console.WriteLine("違う文字列");
            }


            var line = Console.ReadLine();
            int num;
            if (int.TryParse(line, out num)) {
                Console.WriteLine("[0:#,#]", num);
            }
            else { 
                Console.WriteLine("数値文字列ではありませんでした");
            }


            var text = "Jackdaws love my big sphinx of quartz";

            Exercise3_1(text);
            Console.WriteLine("-----");

            Exercise3_2(text);
            Console.WriteLine("-----");

            Exercise3_3(text);
            Console.WriteLine("-----");

            Exercise3_4(text);
            Console.WriteLine("-----");

            Exercise3_5(text);
            {\rtf1}
        }

        private static void Exercise3_1(string text) {
            
        }

        private static void Exercise3_2(string text) {
            
        }

        private static void Exercise3_3(string text) {
            
        }

        private static void Exercise3_4(string text) {
            
        }

        private static void Exercise3_5(string text) {
            
        }
    }
}
