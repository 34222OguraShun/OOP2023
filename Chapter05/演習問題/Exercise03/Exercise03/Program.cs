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
            var count = target.Count(c => c.ToString().Contains(' '));    
            Console.WriteLine(count);
        }

        private static void Exercise3_2(string target) {
            var replaced = target.Replace("big", "small");
            Console.WriteLine(replaced);
        }

        private static void Exercise3_3(string target) {
            int count = target.Split(' ').Length;
            Console.WriteLine("単語数：{0}", count);
        }

        private static void Exercise3_4(string target) {
            var list = new List<string> { "Jackdaws", "love", "my", "big", "sphinx", "of", "quartz" };
            var names = list.FindAll(s => s.Length <= 4);
            foreach (var item in names) {
                Console.WriteLine(item);
            }
            //var words = target.Split(' ').Where(word => word.Length <= 4);
            //foreach (var word in words) {
            //    Console.WriteLine(word);
            //}
        }

        private static void Exercise3_5(string target) {
            var array = target.Split(' ').ToArray();

            //var sb = new StringBuilder();
            //sb.Append(array[0]);
            var sb = new StringBuilder(array[0]);
            foreach (var word in array.Skip(1)) {
                sb.Append(' ');
                sb.Append(word);
            }
            var createWords = sb.ToString();
            Console.WriteLine(createWords);
        }
    }
}
