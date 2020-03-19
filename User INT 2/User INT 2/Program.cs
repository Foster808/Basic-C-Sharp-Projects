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
            int userInt2 = Convert.ToInt32(Console.ReadLine());
         
            
            if (userInt2 > 0)
            {
                Console.WriteLine("You entered a number. We asked you not to.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine();
            }
            Console.ReadLine();
            obj1.MyMethod(userInt, userInt2);
            Console.ReadLine();
        }

    }
}
