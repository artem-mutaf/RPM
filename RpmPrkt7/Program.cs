using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpmPrkt7
{
    class Program
    {
        static void Main(string[] args)
        {
            var stock1 = new Stock("Stock №1", 15);
            Stock stock2 = new Stock("Stock №2", 10);

            stock1.Add("Одежда");
            stock1.Add("Кепки");
            stock2.Add("Жидкости Chaser Lux 65mg");
            stock2.Add("Наборы для самозамеса Chaser");
            stock1.Delete("Одежда");

            List<Stock> stocks = new List<Stock>();
            stocks.Add(stock1);
            stocks.Add(stock2);
            

            Console.WriteLine("Список складов: ");
            foreach(var stock in stocks)
            {
                Console.WriteLine($"Название: {stock.name}, Вместимость: {stock.capacity}, Кол-во товаров: {stock.Inventory.Count}");
            }
            Console.ReadLine();
        }
    }
}
