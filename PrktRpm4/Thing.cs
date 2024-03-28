using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrktRpm4
{
    class Thing
    {
        public string name { get; set; }
        public int weight { get; set; }
        public int price { get; set; }

        public Thing(string name,int weight,int price)
        {
            this.name = name;
            this.weight = weight;
            this.price = price;
        }
    }
}
