using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        //private class ExampleClass { }
        static void Main()
        {
            Employee<int> list1 = new Employee<int>();
            list1.Add(1 + 2 + 3)
            list1.things = 1;

            Employee<string> list2 = new Employee<string>();
            list2.Add("These are our strings to add." + "And another" + "And another");
            list2.things = 2;
        }
    }
            int[] list1 = { 1, 2, 3 };
            foreach (int list2 in Employee<int>)
            {
            Console.WriteLine(list1.things);
            }
    
            string[] list2 = { "These are our strings." };
            foreach (string list2 in Employee<string>)
            {
            Console.WriteLine(list2.things);
            }

    //Employee myObj = new Employee();
        //myObj.things = 1;
        //Console.WriteLine(myObj.things);

    
    

