using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name or enter q to Exit ...");
            string input = Console.ReadLine();
            while (input != "q")
            {
                Console.WriteLine($"Hello {input}");
                input = Console.ReadLine();
            }
            Console.WriteLine("Done");
            Console.WriteLine("Enter your name or enter q to Exit ...");
            string input = Console.ReadLine();

            do
            {
                Console.WriteLine($"Hello {input}");
                input = Console.ReadLine();
            } while (input != "q");



        }
    }
}
