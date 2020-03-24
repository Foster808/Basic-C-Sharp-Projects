using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Employee<T>
    {
        public List<T> Things { get; set; }
        //public string Things { get; set; }
        //public int Things1 { get; set; }

        //T things;

        //public Employee(T t);
        //{
        //    this.things = t;
        //}

        //public void Write()
        //{
        //    Console.WriteLine(this.things);
        //}
    }
    }
    
    

