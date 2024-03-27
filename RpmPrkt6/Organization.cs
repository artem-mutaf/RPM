using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpmPrkt6
{
    class Organization:Factory
    {
        int quantity2;
        public int Quantity2
        {
            get { return quantity2; }
            set { quantity2 = value; }
        }

        public Organization() { }
        public Organization(string nameshop,int quantity,int quantity2):base(nameshop,quantity)
        {
            this.quantity2 = quantity2;
        }
        public override string ToString()
        {
            return base.ToString() + quantity2;
        }

        new public static Organization Name()
        {
            Console.WriteLine("Введите название цеха: ");
            string nameshop = Console.ReadLine();
            Console.WriteLine("Введите кол-во производимого товара: ");
            int quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите кол-во заводов: ");
            int quantity2 = int.Parse(Console.ReadLine());
            return new Organization(nameshop, quantity, quantity2);
        }
    }
}
