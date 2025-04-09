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
            Console.ReadKey();
        }
        static void E1()
        {
            const int r = 5;
            double a;
            a = Math.PI * Math.Pow(r,2);
            Console.WriteLine("El área del círculo sería: "+ a );
        }
        }
    }
