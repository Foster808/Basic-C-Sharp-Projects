using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Approval_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("What is your age?");
            int userAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + userAge);
            Console.ReadLine();

            
            Console.WriteLine("Have you ever had a DUI? Please answer True or False");
            bool userDUI = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Your DUI status is: " + userDUI);
            Console.ReadLine();


       
            Console.WriteLine("How many speeding tickets do you have?");
            int userTickets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your ticket status is: " + userTickets);
            Console.ReadLine();

            bool userInsurance = (userAge > 15 && userDUI == false && userTickets <= 3);

            Console.WriteLine("Your Approval for Car Insurance is: " + userInsurance);
            Console.ReadLine();



        }
    }
}
