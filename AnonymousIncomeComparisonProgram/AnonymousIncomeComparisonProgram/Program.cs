using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousIncomeComparisonProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            Console.WriteLine("Person 1...");
            Console.ReadLine();

            int num1;
            Console.WriteLine("What is your hourly rate?");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.ReadLine();

            int num2;
            Console.WriteLine("How many hours do you work per week?");
            num2 = Convert.ToInt32(Console.ReadLine());
            int result1 = num1 * num2;
            int total1 = result1 * 52;

            Console.ReadLine();

    
            Console.WriteLine("Person 2...");
            Console.ReadLine();

            int num3;
            Console.WriteLine("What is your hourly rate?");
            num3 = Convert.ToInt32(Console.ReadLine());

            Console.ReadLine();

            int num4;
            Console.WriteLine("How many hours do you work per week?");
            num4 = Convert.ToInt32(Console.ReadLine());
            int result2 = num3 * num4;
            int total2 = result2 * 52;
            Console.ReadLine();

            Console.WriteLine("Annual Salary of Person 1 is: " + total1);
            Console.ReadLine();

            Console.WriteLine("Annual Salary of Person 2 is: " + total2);
            Console.ReadLine();


            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(result1 > result2);
            Console.ReadLine();
           
         
        }
    }
}
