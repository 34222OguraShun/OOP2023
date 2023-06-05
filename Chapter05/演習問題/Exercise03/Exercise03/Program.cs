using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {
            var target = "Jackdaws love my big sphinx of quartz";

            Exercise3_1(target);
            Console.WriteLine("-----");

            Exercise3_2(target);
            Console.WriteLine("-----");

            Exercise3_3(target);
            Console.WriteLine("-----");

            Exercise3_4(target);
            Console.WriteLine("-----");

            Exercise3_5(target);
            //{\rtf1}
        }

        private static void Exercise3_1(string target) {
            var count = target.Count(n => n.ToString().Contains(' '));    
            Console.WriteLine(count);
        }

        private static void Exercise3_2(string target) {
            var replaced = target.Replace("big", "small");
            Console.WriteLine(replaced);
        }

        private static void Exercise3_3(string target) {

        }

        private static void Exercise3_4(string target) {

        }

        private static void Exercise3_5(string text) {

        }
    }
}
