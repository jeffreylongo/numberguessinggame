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

            //start:
            Console.WriteLine(num01);
            Console.WriteLine("Guess a number 1 - 100...or else...");
            //var rawInput = var.TryParse(rawInput, out guess);
            var rawInput = Console.ReadLine();
            var number = int.TryParse(rawInput, out guess);


            if (guess == num01)
            {
                Console.WriteLine("You got a Bingo!");
                Console.ReadLine();

            }
            else if ( guess > num01)
            {
                Console.WriteLine("Too high, ya big dummy! Try again...");
                Console.ReadLine();
                counter++;
                if (counter == 5)
                {
                    Console.WriteLine("You Lose!");
                }

            }
            else if ( guess < num01)
            {
                Console.WriteLine("As Little John would say...Too LOW! Try again...");
                Console.ReadLine();
                counter++;
                if (counter == 5)
                {
                    Console.WriteLine("You Lose!");
                }
            }
            
            //Console.WriteLine(num01);
            //Console.ReadLine();
            //goto start;
        }
    }
}
