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
            Employee emp1 = new Employee<int>();
            emp1.Things = new List<int>() { 20, 43, 37, 28, 55 };

            Employee emp2 = new Employee<string>();
            emp2.Things = new List<string>() { "Bananas", "Apples", "Celery" };

            //List<string> things = new List<string>();

            //things.Add("Bananas");
            //things.Add("Apples");
            //things.Add("Celery");
            //Console.WriteLine();

            foreach (thing in things)
            {
                Console.WriteLine(emp1.Things, emp2.Things);
                Console.ReadLine();
            }

            //List<int> things = new List<int>();

            //things.Add(1);
            //things.Add(2);
            //things.Add(3);
            //Console.WriteLine();

            //foreach (int thing in things)
            //{
            //    Console.WriteLine(thing);
            //    Console.ReadLine();
            //}


            //Employee<string> emp1 = new Employee<string>("Apple, " + "Banana, " + "Celery.");
            //emp1.Write();
            ////Console.WriteLine();
            ////Console.ReadLine(); 

            //Employee<int> emp2 = new Employee<int>(5 + 2 + 7);
            //emp2.Write();
            ////Console.WriteLine();
            ////Console.ReadLine();


            //public virtual void ListThings()
            //{ 
            //foreach (Employee things in Employees)
            //{
            //    Console.WriteLine(things.List);
            //    Console.ReadLine();
            //}

            //List<string> Things = new List<string>()
            //{
            //    "banana",
            //    "butter",
            //    "broccoli"
            //};
            //Console.WriteLine();
            //Console.ReadLine();
        }
    }
}


