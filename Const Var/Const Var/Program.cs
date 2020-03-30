using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Const_Var
{
    class Program
    {
        static void Main(string[] args)
        {

            const string ourHello = "Welcome to Saturday!";
            var a = 10;


            Console.WriteLine("We just want to say... {0}!", ourHello);
            Console.WriteLine("Let's do a high: " + a);
            Console.ReadLine();
        }

        class highTen
        {
            private int id;
            private string name;

            public highTen() : this(0, "")
            {

            }

            public highTen (int id, string name)
            {
                this.id = id;
                this.name = name;
            }

            public highTen(int id) : this(id, "")
            {

            }

            public highTen(string name) : this(0, name)
            {

            }

            highTen x = new highTen(), y = new highTen(789, "defined"), z = new highTen("xyz");
        }
    }
}
       
    

