using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrktRpm4
{
    class Backpack
    {
        public List<Thing> Things { get; set; }
        public int capacity { get; set; }

        public Backpack(int capacity)
        {
            this.capacity = capacity;
            Things = new List<Thing>();
        }

        public void Package()
        {
            Things.Sort((x, y) => y.price / y.weight - x.price / x.weight);
            int remCapacity = capacity;

            foreach(var thing in Things)
            {
                if(remCapacity >= thing.weight)
                {
                    Things.Add(thing);
                    remCapacity -= thing.weight;
                }
                else
                {
                    break;
                }
            }

        }
        public void PrintThings()
        {
            Console.WriteLine("Список упакованных предметов в рюкзаке: ");
            foreach(var thing in Things)
            {
                Console.WriteLine($"Предмет: {thing.name}, Вес: {thing.weight} гр., Стоимось: {thing.price} руб");
            }
        }
    }
}
