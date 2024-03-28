using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrktRpm4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Thing> things = new List<Thing>
            {
                new Thing("Ручка",10,4),
                new Thing("Пачка сигарет",40,55),
                new Thing("Ноутбук",1200,4000),
                new Thing("Тетрадь",100,12),
                new Thing("Перцовый балончик",200,500),
                new Thing("Пластиковый контейнер с едой",300,100),
                new Thing("Гантеля",1000,800)
            };
            
            int capacity = 5;

            Backpack backpack = new Backpack(capacity);
            backpack.Things = things;

            backpack.Package();
            backpack.PrintThings();

            Console.ReadLine();
        }
    }
}
