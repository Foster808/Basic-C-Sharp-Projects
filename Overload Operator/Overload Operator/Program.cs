using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.firstName = "Bob";
            emp1.lastName = "Smith";
            emp1.id = 1;
            Employee emp2 = new Employee();
            emp2.firstName = "Joe";
            emp2.lastName = "Jeffries";
            emp2.id = 2;
            Console.WriteLine(emp1 == emp2);
            Console.WriteLine(emp1 != emp2);
            Console.ReadLine();
        }
    }
}
        

