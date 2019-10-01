using System;
using System.Collections.Generic;
using System.Text;

namespace Areas
{
   public class Operaciones
    {

        public double Area(double Lado_A)
        {
            double res = Lado_A*Lado_A;
            return res;
        }
        public double Area(double Lado_A,double Lado_B)
        {
            double res = Lado_A * Lado_B;
            return res;
        }
        public double Area(double Lado_A,double Lado_B,double N)
        {
            N = 2;
            double res = (Lado_A*Lado_B) / N;
            return res;
        }
    }
}
