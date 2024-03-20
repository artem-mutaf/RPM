using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpm3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int FibonacciRecursive(int n)
            {

                
                if (n == 0 || n == 1)
                    return n;
              
                    return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);

               
            }
            int fib4 = FibonacciRecursive(4);
            int fib5 = FibonacciRecursive(5);
            int fib7 = FibonacciRecursive(7);
            int fib9 = FibonacciRecursive(9);
            Console.WriteLine($"4 число фибоначчи = {fib4}");
            Console.WriteLine($"5 число фибоначчи = {fib5}");
            Console.WriteLine($"7 число фибоначчи = {fib7}");
            Console.WriteLine($"9 число фибоначии = {fib9}");

            int FibonacciIterative(int n)
            {
                if (n <= 1)
                    return n;
                int prev = 0;
                int current = 1;
                for (int i = 2; i <= n; i++)
                {
                    int next = prev + current;
                    prev = current;
                    current = next;
                    Console.WriteLine($"\t{next}");
                }
                return current;
                
            }
            FibonacciIterative(16);
            

            Console.ReadKey();
        }
    }
}
