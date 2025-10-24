using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("20 questions");
            Console.WriteLine("I will pick a random number between 1 and 1000000 and you have 20 chances to get it right!");
            int random = new Random().Next(1000000);

            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine("Guess no. " + i + ":");
                int guess = Convert.ToInt32(Console.ReadLine());
                if (i < 20)
                {
                    if (guess == random)
                    {
                        Console.WriteLine("Congratulations, you are correct!");
                        break;
                    }
                    else if (guess < random)
                    {
                        Console.WriteLine("Too low, try again");
                    }
                    else
                    {
                        Console.WriteLine("Too high, try again");
                    }
                }
                else
                {
                    if (guess == random)
                    {
                        Console.WriteLine("Congratulations, you got it right on your last try!");
                    }
                    else
                    {
                        Console.WriteLine("Better luck next time!" + "The number I was looking for was: " + random);
                    }
                }
            }
        }

    }
}
