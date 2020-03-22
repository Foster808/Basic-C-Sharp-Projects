using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload_Operator
{
    class Employee : Person
    {
        public int id { get; set; }
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            return (emp1.id == emp2.id);
                   
        }
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return (emp1.id != emp2.id);
        }
    }
}
