using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divide_by_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Divider obj1 = new Divider();
            
            Console.WriteLine("Please enter a number.");
            int userNum = Convert.ToInt32(Console.ReadLine());
            obj1.MyMethod(userNum);
            //Console.WriteLine("Great. Here's your number divided by 2: " + (userNum / 2));
            Console.ReadLine();
            
        }
            //public Divider obj1 = new Divider(); 
        }
    }

