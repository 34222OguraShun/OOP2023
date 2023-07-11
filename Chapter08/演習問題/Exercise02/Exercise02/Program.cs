using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            foreach (var dateWeek in Enum.GetValues(typeof(DayOfWeek))) {
                Console.WriteLine();
        //        Console.Write("{0:yy/MM/dd(ddd)}", NextWeek(dt.DayOfWeek));
            }
        }
        public static DateTime NextWeek(DateTime date, DayOfWeek dayOfWeek) {
            var days = (int)dayOfWeek - (int)(date.DayOfWeek);
            if (days <= 0) {
                days += 7;
            }
            return date.AddDays(days);

        }
    }
}
