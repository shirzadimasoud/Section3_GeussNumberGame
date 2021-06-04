using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 100);

            Console.Write("Pick a number between 1 to 100 (You have 7 chances) :  ");
            int counter = 0;
            int input = Convert.ToInt32(Console.ReadLine());

            string ans = "y";

            while (ans == "y")
            {
                do
                {

                    if (input == number)
                    {
                        Console.WriteLine("You Win");
                        Console.ReadKey();
                        break;
                    }
                    else if (input > number)
                    {
                        Console.WriteLine("You picked too High! Pick lower !");
                        counter++;
                    }
                    else if (input < number)
                    {
                        Console.WriteLine("You picked too Low! Pick Higher !");
                        counter++;
                    }

                    if (counter == 7)
                    {
                        break;
                    }

                    Console.Write($"Try again !!! (You have {7 - counter} chances) :  ");
                    input = Convert.ToInt32(Console.ReadLine());

                } while (counter < 7);

                if (counter == 7)
                {
                    Console.WriteLine("You Loss !!! Try again later.");
                    Console.ReadKey();
                }
               
            }
        }
    }
}
