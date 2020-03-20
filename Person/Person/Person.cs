using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Person
    {
        public List<string> FullName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; } //prop tab tab

        public void SayName()
        {
            foreach (string person in FullName)
            {
                Console.WriteLine("Name: ", (person));
            }
        }
    }
}
