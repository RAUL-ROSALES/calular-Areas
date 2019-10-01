using System;
using System.Collections.Generic;
using System.Text;

namespace Areas
{
    public class Principal
    {
        Operaciones o = new Operaciones();
        int opc;
        double c1, c2; 
        public void Menu()
        {
            Console.WriteLine("Bienvenido a Mi Programa");
            Console.WriteLine("------------------------");
            Console.WriteLine("1-sacar area de un cuadrado");
            Console.WriteLine("2-sacar el area del un retangulo");
            Console.WriteLine("3-sacar el area de un triangulo");
            Console.WriteLine("Eliga una opcion");
            opc = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("------------------------");
            switch (opc)
            {
                case 1:
                    Console.WriteLine("ingrese un lado del cuadrado");
                    c1 = Convert.ToDouble(Console.ReadLine());
                    double res1 = o.Area(c1);
                    Console.WriteLine("el area del cuadrado es: "+res1);
                    break;
                case 2:
                    Console.WriteLine("ingrese la base del retangulo");
                    c1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("ingrese la altura del retangulo");
                    c2 = Convert.ToDouble(Console.ReadLine());
                    double res2 = o.Area(c1,c2);
                    Console.WriteLine("el area del retangulo es: "+ res2);
                    break;
                case 3:
                    Console.WriteLine("ingrese la base del triangulo");
                    c1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("ingrese la altura del triangulo");
                    c2 = Convert.ToDouble(Console.ReadLine());
                    double res3 = o.Area(c1,c2,2);
                    Console.WriteLine("La base del triangulo es: "+res3);
                    break;
                default:
                    Console.WriteLine("Opcion no validad");
                    Menu();
                    break;
            }

        }
    }
}
