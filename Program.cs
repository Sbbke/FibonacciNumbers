using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {

           var fibonacciNumbers = new List<int> { 1, 1 };

           while(fibonacciNumbers.Count<20)
            {
                var second = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var first = fibonacciNumbers[fibonacciNumbers.Count - 2];

                fibonacciNumbers.Add(first + second);
            }


            foreach (var item in fibonacciNumbers)
                Console.WriteLine(item);
            Console.ReadLine();

        }
    }
}
