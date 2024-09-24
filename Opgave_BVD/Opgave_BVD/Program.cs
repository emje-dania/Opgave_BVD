using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_BVD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Varible list 
            string name;
            bool restart = true;
            int min = 1;
            int max = 100;
            int tries;

            //create / in the game
            while (restart)
            {
                //Start with into and ask for name

                Console.WriteLine("Hello new player, please enter you name");
                name = Console.ReadLine();

                Console.WriteLine($"Welcome {name}, the rules are simple");
                Console.WriteLine("type a number between 1 and 100 in order to guess the randomized number");
                Console.WriteLine("the game will tell you how close you are");
                Console.WriteLine("press enter when you are ready");
                Console.ReadLine();

                // Create a random number
                Random randomNumber = new Random();
                int rnd = randomNumber.Next(min, max + 1);

                //the player picks a number
                Console.WriteLine("type a number between 1 and 100");
                int playerNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Guess: " + playerNumber);

                //Use an if statement to choose what happens when the guess is too high or low
                if (playerNumber > rnd)
                {
                    Console.WriteLine(playerNumber + " is too high");
                } 
                else if (playerNumber < rnd)
                {
                    Console.WriteLine(playerNumber + " is too low");
                }
            }
            

            




            Console.ReadLine();
        }
    }
}
