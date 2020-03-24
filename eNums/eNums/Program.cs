using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eNums
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                DaysOfTheWeek day;
                Console.WriteLine("Please enter the current day of the week: ");
                string input = Console.ReadLine();
                day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), input);

                Console.WriteLine("You said: " + input);
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Please type an actual day of the week.");
                Console.ReadLine();
            }
        }
        public enum DaysOfTheWeek
        {
            None,
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7,
        }
    }
}
