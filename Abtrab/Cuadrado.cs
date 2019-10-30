using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abtrab
{
   public class Cuadrado:Base
   {
        public override double Base_1 { get; set; }
        public override double Altura { get; set; }
        public double AreaCuadrado(double b)
        {
            double res = b * b;
            return res;
        }
        
    }
}
