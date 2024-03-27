using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpmPrkt5
{
    class Equation
    {

        private double a;
        private double b;
        private double c;
        private double D;
        private double x1;
        private double x2;
        public Equation(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void Raschet()
        {
            D = Math.Pow(b, 2) - 4 * a * c;
            if (D > 0 )
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("x1= {0:f2}\n x2= {1:f2}", x1, x2);



            }
            else if (D == 0) //a=1 b=-8 c=16 
            {
                Console.WriteLine("Уравнение имеет один корень:");
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("x1=" + "{0:f2}", x1);
            }
            else
            {
                Console.WriteLine("Действительных корней нет");

            }

        }
    }
}
    

