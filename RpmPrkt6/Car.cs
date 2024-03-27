using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpmPrkt6
{
    class Car:Vehicle
    {
        string brand;
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public Car() { }
        public Car(string whatvehicle,string brand):base(whatvehicle)
        {
            this.Brand = brand;
        }

        public void Print()
        {
            Console.WriteLine($"{Brand}");
        }

        new public static Car Input()
        {
            Console.WriteLine("Введите какое транспортное средство: ");
            string whatvehicle = Console.ReadLine();
            Console.WriteLine($"Введите марку {whatvehicle}: ");
            string brand = Console.ReadLine();
            return new Car(whatvehicle,brand);
        }
    }
}
