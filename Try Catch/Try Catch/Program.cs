using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("How old are you?");
                int userAge;
                userAge = Convert.ToInt32(Console.ReadLine());

                var date01 = DateTime.Now;
                var userYear = date01.AddYears(-userAge);

                DateTime d = new DateTime(int.Parse(userYear, 1, 1);
                userYear = d.ToString("yyyy");
                Console.WriteLine(userYear);
                Console.ReadLine();

                Console.WriteLine("You were born in: " + userYear);
            }
            catch (wrongNumber)
            {
                Console.WriteLine("Please enter a real number and no negatives.");
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a correct age.");
                Console.ReadLine();
            }
            


            

            

            

            

            

        
        }
    }
}
