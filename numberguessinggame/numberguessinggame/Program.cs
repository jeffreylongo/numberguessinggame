using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberguessinggame
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var guess = 0;
            Random rnd = new Random();
            int num01 = rnd.Next(1,100);
            var counter = 0;

            Console.WriteLine(num01);

            while (counter < 5)
            {
                Console.WriteLine("Guess a number 1 - 100...or else...");
                //var rawInput = var.TryParse(rawInput, out guess);
                var rawInput = Console.ReadLine();
                var number = int.TryParse(rawInput, out guess);

                if (guess == num01)
                {
                    Console.WriteLine("You got a Bingo!");
                    Console.ReadLine();
                    break;
                }
                else if (guess > num01)
                {
                    Console.WriteLine($"You guessed {guess}. Too high, ya big dummy! Guesses taken: {counter + 1}");
                    rawInput = Console.ReadLine();
                    number = int.TryParse(rawInput, out guess);
                    counter++;
                    if (counter == 5)
                    {
                        Console.WriteLine("You Lose! Dont quit your day job.");
                    }

                }
                else if (guess < num01)
                {
                    Console.WriteLine($"You guessed {guess}. As Little John would say...Too LOW! Guesses taken: {counter + 1}");
                    rawInput = Console.ReadLine();
                    number = int.TryParse(rawInput, out guess);
                    counter++;
                    if (counter == 5)
                    {
                        Console.WriteLine("You Lose! Dont quit your day job.");
                    }
                }

            }
            Console.WriteLine(counter);
            Console.ReadLine();
        }
    }
}
