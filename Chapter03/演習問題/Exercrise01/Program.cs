using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercrise01 {
    class Program {
        static void Main(string[] args) {

            var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };
            Exercrise1_1(numbers);
            Console.WriteLine();

            Exercrise1_2(numbers);
            Console.WriteLine();

            Exercrise1_3(numbers);
            Console.WriteLine();

            Exercrise1_4(numbers);
            Console.WriteLine();
        }

        private static void Exercrise1_1(List<int> numbers) {
            var exist = numbers.Exists(n => n/8 == 0 && n / 9 == 0);
            if (exist) {
                Console.WriteLine("存在しています");
            }else {
                Console.WriteLine("存在していません");
            }
        }

        private static void Exercrise1_2(List<int> numbers) {
            
        }

        private static void Exercrise1_3(List<int> numbers) {
            
        }

        private static void Exercrise1_4(List<int> numbers) {
            
        }
    }
}
