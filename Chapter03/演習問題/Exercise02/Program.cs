using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            var names = new List<string> { "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong kong" };

            Exercrise2_1(names);
            Console.WriteLine("---------------");

            Exercrise2_2(names);
            Console.WriteLine("---------------");

            Exercrise2_3(names);
            Console.WriteLine("---------------");

            Exercrise2_4(names);
            Console.WriteLine("---------------");
        }

        private static void Exercrise2_1(List<string> names) {
            Console.Write("都市名を入力：");
            do {
                var line = Console.ReadLine();
                if (string.IsNullOrEmpty(line))
                    break;

                var index = names.FindIndex(n => n == line);
                Console.WriteLine(index);
                
            } while (true);

        }

        private static void Exercrise2_2(List<string> names) {
            var count = names.Count(n => n.ToString().Contains('o'));
            Console.WriteLine(count);
        }

        private static void Exercrise2_3(List<string> names) {
            var list = names.Where(n => n.Contains('o')).ToArray();
            foreach (var name in list) {
                Console.WriteLine(name);
            }
        }

        private static void Exercrise2_4(List<string> names) {
            var selected = names.Where(s => s.StartsWith("B")).Select(s => new { s, s.Length });
            foreach (var item in selected) {
                Console.WriteLine(item);
                //Console.WriteLine("{0},{1}", item, item.Length);
            }
        }
    }
}
