using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main()
        {
            Employee<int> emp1 = new Employee<int>();
            emp1.Things = new List<int>() { 22, 7, 54, 99, 2020 };

            Employee<string> emp2 = new Employee<string>();
            emp2.Things = new List<string>() { "Bananas", "Apples", "Celery" };

            foreach (var thing in emp1.Things)
            {
                Console.WriteLine(thing);
            }

            foreach (var thing in emp2.Things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();
        }
    }
}


