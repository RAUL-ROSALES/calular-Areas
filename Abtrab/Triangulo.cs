using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abtrab
{
   public class Triangulo:Base
    {
        public override double Base_1 { get; set; }
        public override double Altura { get; set; }
        public double AreaTriangulo(double a, double b)
        {
            double res = (a * b) / 2;
            return res;
        }
    }
}
