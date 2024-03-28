using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpmPrkt7
{
    struct Stock
    {
        public string name { get; set; }
        public int capacity { get; set; }
        public List<string>Inventory { get; set; }

        public Stock(string name,int capacity)
        {
            this.name = name;
            this.capacity = capacity;
            this.Inventory = new List<string>();
        }
        public void Add(string product)
        {
            if(Inventory.Count<capacity)
            {
                Inventory.Add(product);
                Console.WriteLine($"Товар {product} добавлен на склад {name}");
            }
            else
            {
                Console.WriteLine($"Склад {name} полон...");
            }
        }

        public void Delete(string product)
        {
            if(Inventory.Contains(product))
            {
                Inventory.Remove(product);
                Console.WriteLine($"Товар {product} удален со склада {name}");
            }
            else
            {
                Console.WriteLine($"Товар {product} не найден на складе {name}");
            }
        }



    }
}
