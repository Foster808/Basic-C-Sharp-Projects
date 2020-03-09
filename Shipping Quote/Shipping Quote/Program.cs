using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping_Quote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.ReadLine();

            int userPackage;
            Console.WriteLine("What is the weight of your package?");
            userPackage = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            if (userPackage > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            Console.ReadLine();
            

            int userWidth;
            Console.WriteLine("What is the width of your package?");
            userWidth = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            int userHeight;
            Console.WriteLine("What is the height of your package?");
            userHeight = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            int userLength;
            Console.WriteLine("What is the length of your package?");
            userLength = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            int result = userWidth + userHeight + userLength;
            if (result > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }

            int result2 = userPackage * userWidth * userHeight * userLength;
            int total = result2 / 100;

            Console.WriteLine("Your estimated total for shipping this package is: $" + total);
            Console.ReadLine();



        }
    }
}
