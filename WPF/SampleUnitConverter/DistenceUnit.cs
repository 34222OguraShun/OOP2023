using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleUnitConverter {
   public class DistenceUnit {
        public string Name { get; set; }
        public double Coeffictient { get; set; }
        public override string ToString() {
            return this.Name;
        }
    }
}
