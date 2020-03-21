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

            IQuittable myQuit = new IQuittable();


            myQuit.Quit();

            IQuittable r; //trying to make a reference here
            r = myQuit;
            r.Quit();
        }
    }
}



//Use polymorphism to create an object of type IQuittable and call the Quit() 
//    method on it.Hint: an object can be of an interface type if it implements 
//    that specific interface.
