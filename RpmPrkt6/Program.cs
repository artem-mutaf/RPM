using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpmPrkt6
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine vehicle = Engine.Input();
            
            Organization shop = Organization.Name();

            

            Console.WriteLine(shop.ToString());
            vehicle.Print();

            Console.ReadLine();
        }
    }
}
