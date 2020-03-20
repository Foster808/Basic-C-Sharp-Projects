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
            Employee person = new Employee();
            person.FullName = new List<string>() { "Sample Student" };
            person.SayName();
            Console.ReadLine();
        }
    }
}
