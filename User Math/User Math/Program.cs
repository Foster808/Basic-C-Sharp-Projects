using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Math
{
    class Program
    {
        static void Main(string[] args)
        {
            //STEP 2
            Console.WriteLine("Please enter your favorite number!");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            int result1 = userNumber * 50;
            Console.WriteLine("Your number multiplied by 50 is: " + result1);
            Console.ReadLine();

            int result2 = userNumber + 2;
            Console.WriteLine("Your number plus 2 is: " + result2);
            Console.ReadLine();

            int result3 = userNumber / 1;
            Console.WriteLine("Your number divided by 1 is: " + result3);
            Console.ReadLine();

            //Class1 myNum = new Class1();
            //Console.WriteLine(myNum.result1, myNum.result2, myNum.result3);


        }

    }
}
