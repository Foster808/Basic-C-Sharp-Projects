using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Date_Time
{
    class Program
    {
        static void Main(string[] args)
        {

            double userInput;
            Console.WriteLine("Please enter a number from 1-9.");
            userInput = double.Parse(Console.ReadLine());
            Console.WriteLine("You said, " + userInput);
            Console.ReadLine();


            Console.WriteLine("Right now, our current time is: ");
            //Console.WriteLine(DateTime.Now);
            var date01 = DateTime.Now;
            Console.WriteLine(date01);
            Console.ReadLine();

            Console.WriteLine("The time plus what you chose is: ");
            var resultTime = date01.AddHours(userInput);
            Console.WriteLine(resultTime);
            Console.ReadLine();
            
            
            
            
            
            

            //DateTime ourTime = DateTime.Now;

            
            
            //DateTime theirTime = userInput;
            //DateTime theirTime = DateTime.Now + userInput;

            //TimeSpan resultTime = ourTime + theirTime;
            //Console.WriteLine("This is the actual time plus your number: " + resultTime);
            Console.ReadLine();
        }
    }
}
