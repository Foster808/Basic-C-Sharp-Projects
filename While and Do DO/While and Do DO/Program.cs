using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whiel_and_Do_DO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess today's special number between 1 and 20!");
            int userGuess = Convert.ToInt32(Console.ReadLine());
            bool specialNumber = userGuess == 11;

            // the DO

            do
            {
                switch (userGuess)
                {
                    case 2:
                        Console.WriteLine("You guessesd 2. NOPE.");
                        Console.WriteLine("Guess a number?");
                        userGuess = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 8:
                        Console.WriteLine("You guessed 8. Not this time buddy.");
                        Console.WriteLine("Guess a number?");
                        userGuess = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 10:
                        Console.WriteLine("You guess 10. Closer maybe!");
                        Console.WriteLine("Guess a number?");
                        userGuess = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 11:
                        Console.WriteLine("You GOT IT! Now you are SPECIAL today!!!");
                        specialNumber = true;
                        break;
                    default:
                        Console.WriteLine("SO WRONG.");
                        Console.WriteLine("Guess a number?");
                        userGuess = Convert.ToInt32(Console.ReadLine());
                        break;
                }

            }
            while (!specialNumber);
            Console.Read();
        }
    }
}
