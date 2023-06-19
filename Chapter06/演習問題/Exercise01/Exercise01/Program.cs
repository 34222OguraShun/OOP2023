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
        //Where 取り出す
        //最大値を求め、結果を出力
        private static void Exercise1_1(int[] numbers) {
            var Pages = numbers.Max();
            Console.WriteLine(Pages);
        }


        //最後から2つの要素を取り出す
        private static void Exercise1_2(int[] numbers) {
           // Console.WriteLine(numbers[numbers.Length-1]);
           // Console.WriteLine(numbers[numbers.Length-2]);

            var skip = numbers.Length - 2;
            foreach (var n in numbers.Skip(skip)) {
                Console.WriteLine(n);
           }
        }

        
        //それぞれの数値を文字列に変換して、結果を出力
        private static void Exercise1_3(int[] numbers) {
          //  numbers.ToString();
          //  foreach (var item in numbers) {
          //      Console.Write(item+" ");
          //  }
          //  Console.WriteLine();

            var strs = numbers.Select(n => n.ToString());
            foreach (var s in strs) {
                Console.WriteLine(s);
            }
        
        }


        //数の小さい順に並べ、先頭から3つを取り出し、結果を出力
        private static void Exercise1_4(int[] numbers) {
            foreach (var n in numbers.OrderBy(n => n).Take(3)) {
                Console.WriteLine(n);
            } 
        }


        //重複を排出した後、10より大きい値がいくつあるのかカウントし、結果を出力
        private static void Exercise1_5(int[] numbers) {
            var count = numbers.Distinct().Count(n => n > 10);
            Console.WriteLine(count);
        }
    }
}
