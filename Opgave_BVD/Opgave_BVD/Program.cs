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
            bool play = true;
            int min = 1;
            int max = 100;
            int rnd;
            int guess;
            int tries;
            string response;

            //Start with into and ask for name
            Console.WriteLine("Hello new player, please enter you name");
            name = Console.ReadLine();

            Console.WriteLine($"Welcome {name}, the rules are simple");
            Console.WriteLine("type a number between 1 and 100 in order to guess the randomized number");
            Console.WriteLine("the game will tell you how close you are");
            Console.WriteLine("press enter when you are ready");
            Console.ReadLine();

            //create / in the game
            while (play)
            {
                // these are set to 0 in order to be reset
                guess = 0;
                tries = 0;
                response = "";
                

                // Create a random number
                Random randomNumber = new Random();
                rnd = randomNumber.Next(min, max + 1);

                //Te player picks there first number
                Console.WriteLine("Guess a number between 1 - 100");

                // as long as the guess is not equal to the random number the guessing continues
                while (guess != rnd)
                {

                    //the number the player picked gets defined                   
                    guess = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Guess: " + guess);

                    //Use an if statement to choose what happens when the guess is too high or low
                    if (guess> rnd)
                    {
                        Console.WriteLine(guess + " is too high");
                    }
                    else if (guess < rnd)
                    {
                        Console.WriteLine(guess + " is too low");
                    }
                    tries++;

                }
                // changing the background color so the score stands out more
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                //Play found the random number and can now see there 'score'
                Console.WriteLine("Number: " + rnd);
                Console.WriteLine("You Win!!");
                Console.WriteLine("Tries: " +tries);

                //Change the Backgound color back to normal
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;

                // Now to make the game replayable. "ToUpper" makes it so that the answer stays uppercase
                Console.WriteLine("Play again? (Y/N)");
                response = Console.ReadLine();
                response = response.ToUpper();

                // if Y then restart the game. if N then say goodbye
                if (response == "Y")
                {
                    play = true;
                }
                else
                {
                    play = false;
                }
                
            }
            Console.WriteLine("Thank you for playing");
            Console.ReadKey();

        }
    }
}
