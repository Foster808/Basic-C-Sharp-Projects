using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Hello, there...";
            string name1 = "don't ya know ";
            string name2 = "this is going to be a great day!?";

            Console.WriteLine(name + name1 + name2);
            Console.ReadLine();

            string name3 = "So just have a great day!";
            name3 = name3.ToUpper();
            Console.WriteLine(name3);
            Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            sb.Append("My name is Lara. \n And I'm the one showing you... \n how to have a \n GREAT day!");


            Console.WriteLine(sb);
            Console.ReadLine();



        }
    }
}
