using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Two
{
    class Employee : Person2, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + lastName);
        }
        public void Quit()
        {
            Console.WriteLine(firstName + " " + lastName + "has quit!");
            
        }
    }
}
