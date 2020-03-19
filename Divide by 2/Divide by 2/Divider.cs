using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divide_by_2
{
    class Divider
    {
        public void MyMethod(int x)
        {
            int input = x;

            Console.WriteLine("Your number divided by 2 is: " + (x / 2));
            Console.ReadLine();
        }
        static void MyMethod(int x, int y)
        {
            Console.WriteLine("MyMethod(int x, int y)");

            //Console.WriteLine("Your number divided by 2 is: " + (x / 2));
            //Console.ReadLine();
        }

    }
}
