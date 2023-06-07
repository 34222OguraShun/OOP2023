using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };

            Exercise1_1(numbers);
            Console.WriteLine("-----");

            Exercise1_2(numbers);
            Console.WriteLine("-----");

            Exercise1_3(numbers);
            Console.WriteLine("-----");

            Exercise1_4(numbers);
            Console.WriteLine("-----");

            Exercise1_5(numbers);
        }

        private static void Exercise1_1(int[] numbers) {
            var Pages = numbers.Max();
            Console.WriteLine(Pages);
        }

        private static void Exercise1_2(int[] numbers) {
            Console.WriteLine(numbers[numbers.Length-1]);
            Console.WriteLine(numbers[numbers.Length-2]);

        //    var skip = numbers.Length - 2;
        //    foreach (var n in numbers.Skip(skip)) {
        //        Console.WriteLine(n);
        //    }
        }

        private static void Exercise1_3(int[] numbers) {
            numbers.ToString();
            foreach (var item in numbers) {
                Console.Write(item+" ");
            }
            Console.WriteLine();
        
            //var str = 
        
        }

        private static void Exercise1_4(int[] numbers) {
           // var small = numbers.Where(s => numbers.OrderBy());
        }

        private static void Exercise1_5(int[] numbers) {
            
        }
    }
}
