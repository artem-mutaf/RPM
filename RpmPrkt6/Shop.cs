using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpmPrkt6
{
    class Shop
    {
        string nameshop;
        public string Nameshop
        {
            get { return nameshop; }
            set { nameshop = value; }
        }
        public Shop() { }
        public Shop(string nameshop)
        {
            this.Nameshop = nameshop;
        }

        public override string ToString()
        {
            return $"{Nameshop}\n";
        }
        public static Shop Name()
        {
            Console.WriteLine("Введите название цеха: ");
            string nameshop = Console.ReadLine();
            return new Shop(nameshop);

        }
    } 

}
