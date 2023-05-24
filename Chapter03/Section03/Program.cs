﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section03 {
    class Program {
        static void Main(string[] args) {
            var list = new List<string> {"Tokyo","New Delhi","Bangkok","London","Paris","Berlin","Canberra","Hong kong" };

            //var exists = list.Exists(s => s[2] == 'A');
            //  Console.WriteLine(exists);

            //var name = list.Find(s => s.Length == 6);
            //Console.WriteLine(name);
        
            //var names = list.FindAll(s => s.Length <= 5);
            //names.ForEach(s  => Console.WriteLine(s));

            var names = list.ConvertAll(s => s.ToLower());
            names.ForEach(s => Console.WriteLine(s));
        }
    }
}
