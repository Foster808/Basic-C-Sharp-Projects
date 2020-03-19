using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_INT_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj1 = new Class1();

            Console.WriteLine("Please enter two separate numbers. One at a time.");
            int userInt = Convert.ToInt32(Console.ReadLine());
            int userInt2 = Convert.ToInt32(Console.ReadLine());
            obj1.MyMethod(userInt, userInt2);
            Console.WriteLine("Thanks. We've multiplied your first number by 11, and just shown you your second number whole.");

            Console.ReadLine();
        }
    }
}
