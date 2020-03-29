using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Const_Var
{
    class Program
    {
        static void Main(string[] args)
        {

            const string ourHello = "Welcome to Saturday!";
            var a = 10;


            Console.WriteLine("We just want to say... {0}!", ourHello);
            Console.WriteLine("Let's do a high: " + a);
            Console.ReadLine();
        }

            public class highTen
        {

            public highTen() : this(string.Empty, string.Empty, string.Empty)
            {
                Console.WriteLine("highTen() constructor called");
            }

            public highTen(string firstName, string lastName) : this(firstName, lastName, string.Empty)
            {
                Console.WriteLine("highTen(firstName,lastName) constructor called");
            }

            public highTen(string firstName, string lastName, string nickName)
            {
                Console.WriteLine("highTen(firstName,lastName,nickName) constructor called");
                if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName) && !string.IsNullOrEmpty(nickName));
                
                
            }

        }
    }
       
    }

