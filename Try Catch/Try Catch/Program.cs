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
            {
                try
                {
                    Console.WriteLine("How old are you?");
                    int userAge;
                    userAge = Convert.ToInt32(Console.ReadLine());

                    var date01 = DateTime.Now.Year;
                    var userYear = (date01 - userAge);

                    if (userAge == 0)
                        throw new System.wrongNumber();

                    if (userAge < 0)
                        throw new System.wrongNumber();

                    //Console.WriteLine(userYear);

                    Console.WriteLine("You were born in: " + userYear);
                    Console.ReadLine();
                }
                catch (wrongNumber)
                {
                    Console.WriteLine("Please enter a correct age.");
                    Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a real number (not zero) and no negatives.");
                    Console.ReadLine();
                }
            }


            

            

            

            

            

        
        }
    }
}
