using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's do some math! Hit ENTER to continue...");
            Console.ReadLine();

            int num1;
            Console.Write("Pick a number and let's multiply it by 50!");
            num1 = Convert.ToInt32(Console.ReadLine());
            int result1 = num1 * 50;
            Console.WriteLine("Output: " + result1);
            Console.ReadLine();

            //input from the user, adds 25 to it, and prints the result to the console

            int num2;
            Console.Write("Pick a number and let's add 25 to it!");
            num2 = Convert.ToInt32(Console.ReadLine());
            int result2 = num2 + 25;
            Console.WriteLine("Output: " + result2);
            Console.ReadLine();


            //input from the user, divides it by 12.5, and prints the result to the console.
            

            Console.WriteLine("Pick a number and let's divide it by 12.5!");
            int first = Convert.ToInt32(Console.ReadLine());
            var second = 12.5;

            Console.WriteLine(first / second);

            Console.ReadKey();

            //input from the user, checks if it is greater than 50, and prints the true / false result to the console



            int num4;
            Console.Write("Now pick a number and we'll tell you if it's greater than 50 or not!");
            num4 = Convert.ToInt32(Console.ReadLine());
            bool trueOrFalse = num4 > 50;
            Console.Write(trueOrFalse.ToString());
            Console.ReadLine();

            //input from the user, divides it by 7, and prints the remainder to the console(tip: think % operator)

            int num5;
            Console.Write("Now pick a number and we'll divide it by 7 and show you the remainder!");
            num5 = Convert.ToInt32(Console.ReadLine());
            int result5 = num5 % 7;
            Console.WriteLine("Output: " + result5);
            Console.ReadLine();


        }
    }
}
