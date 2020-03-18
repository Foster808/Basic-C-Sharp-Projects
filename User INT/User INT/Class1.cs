using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_INT
{
    public class Class1
    {
        public void MyMethod(int x)
        {
            int input = x;

            Console.WriteLine("Your number minus 10 is: " + (x - 10));
            Console.ReadLine();

        }

        public void MyMethod(decimal x)
        {
            decimal a = x - 2.1m;
            Console.WriteLine("Your number plus 2.1 is: " + a);
            
            Console.ReadLine();
        }

        public void MyMethod(string x)
        {
            string a = x;

            int result = Convert.ToInt32(a);
            Console.WriteLine("Now, here's a string converted to a number..." + result);
            
        }

    }
}
