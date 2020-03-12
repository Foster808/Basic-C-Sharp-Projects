using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // STEP 1

            try
            {
                int num1;
                Console.WriteLine("Please choose a number so we can do some math!");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.ReadLine();



                List<int> intList = new List<int>();
                intList.Add(50);
                intList.Add(32);
                intList.Add(10);
                intList.Add(100);

                Console.ReadLine();


                foreach (int i in intList)
                {
                    if (i > 0)
                    {
                        Console.WriteLine("Here are my numbers divided by your number: " + i / num1);
                    }
                }
                Console.ReadLine();


            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number.");
            }
           
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero.");
            }
            finally //guarantees that is final line will be read and executed
            {
                Console.ReadLine();
            }
            Console.ReadLine();





            // STEP 2 -- done
            // STEP 3 -- enter 0
            // STEP 4 -- jesse
            // STEP 5 -- enter try/catch block


        }
    }
}
