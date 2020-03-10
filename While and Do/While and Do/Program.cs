using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_and_Do
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess my favorite number!");
            int userGuess = Convert.ToInt32(Console.ReadLine());
            bool favNumber = userGuess == 7;

            // the WHILE loop

            while (!favNumber) 
            {
                switch (userGuess)
                {
                    case 15:
                        Console.WriteLine("You guessesd 15. Try again.");
                        Console.WriteLine("Guess a number?");
                        userGuess = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 10:
                        Console.WriteLine("You guessed 10. Try again.");
                        Console.WriteLine("Guess a number?");
                        userGuess = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("You guess 3. Try again.");
                        Console.WriteLine("Guess a number?");
                        userGuess = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 7:
                        Console.WriteLine("You guessed the LUCKY number 7. That is correct!");
                        favNumber = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess a number?");
                        userGuess = Convert.ToInt32(Console.ReadLine());
                        break;
                }

            } 
            Console.Read();
        }
    }
}
