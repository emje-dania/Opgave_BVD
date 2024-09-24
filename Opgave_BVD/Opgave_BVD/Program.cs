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
            //Start with into and ask for name
            string name;

            Console.WriteLine("Hello new player, please enter you name");
            name = Console.ReadLine();

            Console.WriteLine($"Welkome {name}, the rules are simple");
            Console.WriteLine("type a number between 1 and 100 in order to guess the randomized number");
            Console.WriteLine("the game will tell you how close you are");
            Console.WriteLine("press enter when you are ready");
            Console.ReadLine();

            //the player picks a number
            Console.WriteLine("type a number between 1 and 100");
            int playerNumber = int.Parse(Console.ReadLine());

            // Random number generator
            Random randomNumber = new Random();
            int rnd = randomNumber.Next(1, 101);
            
            Console.WriteLine("the random number is:  "+rnd);


            Console.ReadLine();
        }
    }
}
