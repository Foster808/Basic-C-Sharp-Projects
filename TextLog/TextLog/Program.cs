using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextLog
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            Console.WriteLine("Please enter a number.");
            userInput = Convert.ToString(Console.ReadLine());
            File.WriteAllText(@"C:\Users\LaFos\Logs\log.txt", userInput);

            Console.ReadLine();

            Console.WriteLine("You said: " + userInput);
            using (StreamWriter file = new StreamWriter(@"C:\Users\LaFos\Logs\log.txt", true))
            {
                file.WriteLine(userInput);
            }
            Console.ReadLine();
        }
    }
}
