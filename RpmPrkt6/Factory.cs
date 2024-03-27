using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpmPrkt6
{
    class Factory:Shop
    {
        int quantity;
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public Factory() { }
        public Factory(string nameshop,int quantity) :base(nameshop)
        {
            this.quantity = quantity;
        }
        public override string ToString()
        {
            return $"{base.ToString()}\n {Quantity}";
        }

        new public static Factory Name()
        {
            Console.WriteLine("Введите название цеха: ");
            string nameshop = Console.ReadLine();
            Console.WriteLine("Введите кол-во производимого товара: ");
            int quantity = int.Parse(Console.ReadLine());
            return new Factory(nameshop,quantity);

        }
    }
}
