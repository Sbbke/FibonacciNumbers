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
            /*var names = new List<string> { "Killer Queen", "Ana", "Felipe" };

            var index = names.IndexOf("Killer Queen");
            if (index != -1)
                Console.WriteLine($"The name {names[index]} is at index {index}");
            var notFound = names.IndexOf("Not Found");
            Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");
            names.Sort();
            foreach(var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");

            }*/

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
