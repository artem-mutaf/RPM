using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpmPrkt6
{
    class Vehicle
    {
        string whatvehicle;
        public string Whatvehicle
        {
            get { return whatvehicle; }
            set { whatvehicle = value; }
        }

        public Vehicle() { }
        public Vehicle(string whatvehicle)
        {
            this.Whatvehicle = whatvehicle;
        }

        public void Print()
        {
            Console.WriteLine($"{Whatvehicle}");
        }

        public static Vehicle Input()
        {
            Console.WriteLine("Введите какое транспортное средство: ");
            string whatvehicle = Console.ReadLine();
            return new Vehicle(whatvehicle);
        }
    }
}
