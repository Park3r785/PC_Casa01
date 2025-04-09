using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            E1();
            E2();
            Console.ReadKey();
        }
        static void E1()
        {
            const int r = 5;
            double a;
            a = Math.PI * Math.Pow(r, 2);
            Console.WriteLine("El área del círculo sería: " + a);
        }
        static void E2()
        {
            double catetoA = 3;
            double catetoB = 4;
            double hipotenusa = Math.Sqrt(Math.Pow(catetoA, 2) + Math.Pow(catetoB, 2));
            // h = sqrt(a^2 + b^2)
            Console.WriteLine("Longitud de la hipotenusa: " + hipotenusa);
        }
        }
    }
