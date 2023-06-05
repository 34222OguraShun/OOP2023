using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Chapter5
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
        }
    }
}
