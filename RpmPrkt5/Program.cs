using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpmPrkt5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double a, b, c;
            Console.Write("Введите а:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите c:");
            c = Convert.ToDouble(Console.ReadLine());

            Equation eq = new Equation(a, b, c);

            eq.Raschet();


            Console.ReadKey();
        }
    }
}
