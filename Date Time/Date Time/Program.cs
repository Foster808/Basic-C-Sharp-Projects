﻿using System;
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
            Console.WriteLine("Right now, our current time is: ");
            Console.WriteLine(DateTime.Now);
            
            int userInput;
            Console.WriteLine("Please enter a number.");
            userInput = int.Parse(Console.ReadLine());
            Console.WriteLine("You said, " + userInput);
            Console.ReadLine();

            DateTime ourTime = DateTime.Now;
            
            DateTime theirTime = userInput;
            //DateTime theirTime = DateTime.Now + userInput;

            TimeSpan resultTime = ourTime + theirTime;
            Console.WriteLine("This is the actual time plus your number: " + resultTime);
            Console.ReadLine();
        }
    }
}