using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpmPrkt6
{
    class Engine:Car
    {
        int power;
        public int Power
        {
            get { return power; }
            set { power = value; }
        }

        public Engine() { }
        public Engine(string whatvehicle, string brand,int power) : base(whatvehicle,brand)
        {
            this.Power = power;
        }

        public void Print()
        {
            Console.WriteLine($"{Power}");
        }

        new public static Engine Input()
        {
            Console.WriteLine("Введите какое транспортное средство: ");
            string whatvehicle = Console.ReadLine();
            Console.WriteLine($"Введите марку {whatvehicle}: ");
            string brand = Console.ReadLine();
            Console.WriteLine("Введите мощность л.с: ");
            int power = int.Parse(Console.ReadLine());
            return new Engine(whatvehicle, brand,power);
        }

    }
}
