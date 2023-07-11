﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            //var dateTime = new DateTime(2019, 1, 15, 19, 48, 32);
            var dateTime = DateTime.Now;
            DisplayDatePattern1(dateTime);
            DisplayDatePattern2(dateTime);
            DisplayDatePattern3(dateTime);
            DisplayDatePattern3_2(dateTime);
        }
        //p208
        private static void DisplayDatePattern1(DateTime dateTime) {
            //2019/1/15 19:48
            Console.WriteLine(dateTime.ToString("g"));
        }

        private static void DisplayDatePattern2(DateTime dateTime) {
            //2019年01月15日 19時48分32秒 
            Console.WriteLine(dateTime.ToString("yyyy年MM月dd日　HH時mm分ss秒"));
        }

        private static void DisplayDatePattern3(DateTime dateTime) {
            //平成31年 1月15日(火曜日)    
            
            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();

            var str = dateTime.ToString("ggyy年 M年d日 ", culture);// 日付を和暦に
            var dayOfWeek = culture.DateTimeFormat.GetDayName(dateTime.DayOfWeek);//曜日を得る
            
            
            Console.WriteLine(str + "("+ dayOfWeek+")");
        }

        
        private static void DisplayDatePattern3_2(DateTime dateTime) {
            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
        
            var date = dateTime.ToString("ggyy年 MM年dd日(dddd)", culture);// 日付を和暦にして、曜日を取得
            var str = Regex.Replace(date, @"0(\d)" , "$1");//0を消す
            Console.WriteLine(str);
        }
    }
}
