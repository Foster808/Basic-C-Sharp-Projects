using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person myPerson = new Person();

            myPerson.SayName();

            Console.WriteLine("Name: " + myPerson.firstName + myPerson.lastName);
            Console.ReadLine();
            //Employee person = new Employee();
            //person.FullName = new List<string>() { "Sample Student" };
            ////person.SayName();
            //Console.WriteLine("Name: ");
            //Console.ReadLine();
        }
    }
}
