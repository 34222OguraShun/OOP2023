using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleUnitConverter {
    //グラム単位を表すクラス
    public class WeightUnit : DistanceUnit {
        private static List<WeightUnit> units = new List<WeightUnit> {
            new WeightUnit{Name = "mg",Coefficient = 1 / 1000,},
            new WeightUnit{Name = "g" ,Coefficient = 1,},
            new WeightUnit{Name = "kg",Coefficient = 1 * 1000 *1000,},
            new WeightUnit{Name = "t" ,Coefficient = 1 * 1000 * 1000 * 1000,},
        };
        public static ICollection<WeightUnit> Units { get { return units; } }

        /// <summary>
        /// グラム単位からポンド単位に変換します
        /// </summary>
        /// <param name="unit">グラム単位</param>
        /// <param name="value">値</param>
        /// <returns>変換値</returns>
        public double FromPoundUnit(PoundUnit unit, double value) {
            return ( value * unit.Coefficient ) * 28.35 / this.Coefficient;
        }


    }
}
