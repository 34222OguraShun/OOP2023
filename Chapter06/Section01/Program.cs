using Chapter06;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            var numbers = new List<int> { 9, 7, 5, 4, 2, 5, 4, 0, 4, 1, 0, 4 };

            Console.WriteLine(numbers.Average());


            var books =Books.GetBooks();

            Console.WriteLine(books.Max(x => x.Pages));


            // var booksObj = books.Where(x => x.Pages >= 500).OrderByDescending(x => x.Price);

            var booksObj = books.Where(x => x.Title.Contains("物語")).Average(x => x.Pages);
                //OrderByDescending(x => x.Pages);
            
//            foreach (var book in booksObj) {
//                Console.WriteLine("{0}:{1}",book.Title,book.Price);
//            }

            Console.WriteLine("ページ平均："+booksObj);
        }
    }
}
