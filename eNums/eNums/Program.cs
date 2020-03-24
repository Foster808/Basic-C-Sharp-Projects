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
            string value = "None";

            DaysOfTheWeek day;
            try
            {
                day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), value);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please type a day of the week.");
                Console.ReadLine();

                day = DaysOfTheWeek.None;
            }
            if (day == DaysOfTheWeek.Monday)
            {

            }
            DaysOfTheWeek today = DaysOfTheWeek.Monday;
            string userInput;
            Console.WriteLine("Please enter the current day of the week: ");
            userInput = Convert.ToString(Console.ReadLine());


            Console.WriteLine("You said: " + userInput);
            Console.ReadLine();

            List<string> list = new List<string>(); //assign the value to a variable
            list.Add(userInput);


            //Console.WriteLine(DaysOfTheWeek.Friday);
            //Console.WriteLine((int)DaysOfTheWeek.Friday);
            //Console.ReadLine();


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