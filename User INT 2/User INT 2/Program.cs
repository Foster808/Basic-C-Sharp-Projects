using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_INT_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pass obj1 = new Pass();

            Console.WriteLine("Please enter two separate numbers. One at a time. Also enter nothing (not zero) as the second number.");
            int userInt = Convert.ToInt32(Console.ReadLine());
            string userInt2 = Console.ReadLine();
         
            
            if (userInt2 == "")
            {
                Console.WriteLine("Thanks for following directions!");
                obj1.MyMethod(userInt);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("We asked you not to enter a number!");
                int userInt3 = Convert.ToInt32(userInt2);
                obj1.MyMethod(userInt, userInt3);
            }
            Console.ReadLine();
        }

    }
}
