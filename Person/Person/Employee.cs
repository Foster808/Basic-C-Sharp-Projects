using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Employee : Person
    {
        public void Id(int[] args)
        {
                Person myObj = new Person();
                myObj.FirstName = "Sample";
                myObj.LastName = "Student";
                Console.WriteLine(myObj.FullName);
            }
        }
    }

