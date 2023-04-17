using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0411 {
    class Program {
        static void Main(string[] args) {
            int count = int.Parse(Console.ReadLine());

            //2
            NewMethod(count);

            Console.WriteLine();
            Console.WriteLine();


            //3
            NewMethod1(count);

            Console.WriteLine();
            Console.WriteLine();




            //4
            NewMethod2(count);

            Console.WriteLine();
            Console.WriteLine();


            //5

            string[] manayString = {" 一万円札","五千円札","五千円札:","千円札:","五百円玉:","百円玉:","五十円玉:","十円玉:","五円玉:","一円玉:" };
            int[] moneyInteger = { 10000, 5000, 1000, 500, 100, 50, 10, 5, 1 };

            Console.Write("金額　　:");
            int Amount = int.Parse(Console.ReadLine());

            Console.Write("支払　　:");
            int payment = int.Parse(Console.ReadLine());

            int Change = payment - Amount;
            Console.WriteLine("お釣り　:" + Change);

            Console.WriteLine("一万円札:" + Change / 10000 + "枚");
            Change %= 10000;

            Console.WriteLine("五千円札:" + Change / 5000 + "枚");
            Change %= 5000;

            Console.WriteLine("千円札:" + Change / 1000 + "枚");
            Change %= 1000;

            Console.WriteLine("五百円玉:" + Change / 500 + "枚");
            Change %= 500;

            Console.WriteLine(c + Change / 100 + "枚");
            Change %= 100;

            Console.WriteLine("五十円玉:" + Change / 50 + "枚");
            Change %= 50;

            Console.WriteLine("十円玉:" + Change / 10 + "枚");
            Change %= 10;

            Console.WriteLine("五円玉:" + Change / 5 + "枚");
            Change %= 5;

            Console.WriteLine("一円玉:" + Change + "枚");


        }

        private static void NewMethod2(int count) {
            for (int k = 0; k < count; k++)
            {

                for (int j = count; j > count - (k + 1); j--)
                {
                    Console.Write(" ");
                }
                for (int i = count; i > (k + 1); i--)
                {

                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        private static void NewMethod1(int count) {
            for (int k = 0; k < count; k++)
            {

                for (int j = 0; j < count - (k + 1); j++)
                {
                    Console.Write(" ");
                }
                for (int i = 0; i < (k + 1); i++)
                {

                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        private static void NewMethod(int count) {
            for (int k = 0; k < count; k++)
            {

                for (int j = 0; j < count - (k + 1); j++)
                {
                    Console.Write(" ");
                }
                for (int i = 0; i < (k + 1); i++)
                {

                    Console.Write("*");
                }
                Console.WriteLine();

            }
        }
    }
}
