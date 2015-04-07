using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipACoin
{
    class Program
    {
        static Random rng = new Random();
        static int headsCounter = 0;
        static int tailsCounter = 0;

        static void Main(string[] args)
        {

            string userChoice = " ";

            Console.WriteLine("Time to flip some coins!");
            Console.WriteLine("Would you like to play? Y/N");
            userChoice = Console.ReadLine().ToUpper();

            if (userChoice == "Y")
            {

                for (int i = 0; i < 1000; i++)
                {
                    Console.WriteLine(FlipACoin());
                }

                Console.WriteLine(headsCounter);
                Console.WriteLine(tailsCounter);
                Console.WriteLine("Thanks for playing!");
                Console.WriteLine("Press any key to quit.");

                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("Why don't you want to play? I wrote this program just for you!");
                Console.WriteLine("Press any key to exit my well coded program.");
                Console.ReadKey();
            }

        }


        public static string FlipACoin()
        {
            if (rng.Next(2) == 0)
            {
                headsCounter++;
                return "You got heads!";
            }
            else
            {
                tailsCounter++;
                return "You got tails!";
            }
        }
    }
}
