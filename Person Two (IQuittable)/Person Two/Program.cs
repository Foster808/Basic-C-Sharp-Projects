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
            Console.ReadLine();

            IQuittable myQuit = new Employee();


            myQuit.Quit();
        }
        static void Main1(string[] args)
        {
            Person myObj = new Person();
            Person myObj1 = new Person();
            myObj.Name = "Employee1";
            myObj1.Name = "Employee1";
            Console.WriteLine(myObj.Name == myObj1.Name);
            Console.ReadLine();
        }
    }
}

