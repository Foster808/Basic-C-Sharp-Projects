using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee person = new Employee();

            person.SayName();

            Console.WriteLine("Name: " + person.firstName + person.lastName);
            Console.ReadLine();
        }
    }
}
