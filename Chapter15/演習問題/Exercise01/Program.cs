using Chapter15;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {

            Exercise1_2();
            Console.WriteLine();

            Exercise1_3();
            Console.WriteLine();

            Exercise1_4();
            Console.WriteLine();

            Exercise1_5();
            Console.WriteLine();

            Exercise1_6();
            Console.WriteLine();

            Exercise1_7();
            Console.WriteLine();

            Exercise1_8();
            Console.ReadLine();
        }

        private static void Exercise1_2() {
            var priceMax = Library.Books.Max(b => b.Price);
            var books = Library.Books.Where(b => b.Price == priceMax);
            
            foreach (var book in books) {
                Console.WriteLine(book);
            }
            
        }

        private static void Exercise1_3() {
            var groups = Library.Books
                                .GroupBy(b => b.PublishedYear)
                                .Select(g => new { PublishedYear = g.Key,Count = g.Count() })
                                .OrderBy(x => x.PublishedYear);
            foreach (var book in groups) {
                Console.WriteLine("{0}年 {1}冊",book.PublishedYear,book.Count);
            }
        }

        private static void Exercise1_4() {
            var query = Library.Books.Join(Library.Categories,
                                           book => book.CategoryId,
                                           category => category.Id,
                                           (book,category) => new {
                                           book.PublishedYear,
                                           book.Price,
                                           book.Title,
                                           CategoryName = category.Name,
                                           })
                                     .OrderBy(b => b.PublishedYear)
                                     .OrderBy(b => b.Price);

            foreach (var item in query) {
                Console.WriteLine("{0}年 {1}円 {2} ({3})",
                                 item.PublishedYear,
                                 item.Price,
                                 item.Title,
                                 item.CategoryName
                                 );
            }

        }

        private static void Exercise1_5() {
            var query = Library.Books.Where(b => b.PublishedYear == 2016)
                                           .Join(Library.Categories,
                                           book => book.CategoryId,
                                           category => category.Id,
                                           (book, category) => category.Name).Distinct();
            foreach (var book in query) {
                Console.WriteLine(book);
            }
        }

        private static void Exercise1_6() {
            var query = Library.Books.Join(Library.Categories,
                                           book => book.CategoryId,
                                           category => category.Id,
                                           (book, category) => new {
                                               book.PublishedYear,
                                               book.Price,
                                               book.Title,
                                               CategoryName = category.Name,
                                           })
                                     .GroupBy(b => b.CategoryName)
                                     .OrderBy(b => b.Key);

            foreach (var group in query) {
                Console.WriteLine();
            }
        }

        private static void Exercise1_7() {
            var catid = Library.Categories.Single(c => c.Name == "Development").Id;
            var groups = Library.Books.Where(b => b.CategoryId == catid)
                                      .GroupBy(b => b.PublishedYear)
                                      .OrderBy(b => b.Key);
            foreach (var group in groups) {
                Console.WriteLine("#[0]年",group.Key);
                foreach (var book in group) {
                    Console.WriteLine(" {0} ", book.Title);
                }
            }
        }

        private static void Exercise1_8() {
            var query = Library.Categories
                               .GroupJoin(Library.Books,
                                                  c => c.Id,
                                                  b => b.CategoryId,
                                                  (c, b) => new {
                                                      CategoryName = c.Name,
                                                      Count = b.Count()
                                                  }).
                                                  Where(x => x.Count >= 4);

            foreach (var category in query) {
                Console.WriteLine(category.CategoryName);
            }
        }
    }
}
