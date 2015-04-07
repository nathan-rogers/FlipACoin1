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
        static int attempts = 1;

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
                Console.WriteLine("Press any key to continue to flip for heads contest!");

                Console.ReadKey();
                 

            }
            else
            {
                Console.WriteLine("Why don't you want to play? I wrote this program just for you!");
                Console.WriteLine("Press any key to continue to flip for heads contest!\n\n");
                Console.ReadKey();
            }

            Console.WriteLine("\n\nLet's see how many times it takes to flip a coin to get heads!\n\n");
            Console.ReadKey();
            Console.WriteLine();
            FlipForHeads();
            Console.WriteLine("\n\nYou got heads! I can't believe it only took you " + attempts + " attempts!");

            Console.ReadKey();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }

        public static void FlipForHeads()
        {
            

            //if 0 = heads
            //flip while not heads
            while (rng.Next(2) != 0)
            {
                Console.WriteLine("Oh no! You got a tails! Try again! \nPress any key to continue...");
                Console.ReadKey();
                attempts++;
            }


            
        }
        /// <summary>
        /// Function retreive random value, and display heads or tails
        /// </summary>
        /// <returns>heads or tails</returns>
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
