using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_INT
{
    public class Program
    {
        static void MyMethod()
        {
            Console.WriteLine("Let's talk numbers... Pick one...");
            int userInt = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            int result = userInt - 10;
            Console.WriteLine("Your number minus 10 is: " + result);
            Console.ReadLine();

            decimal a = 2.1m;
            Console.WriteLine("Your number plus 2.1 is: ");
            Console.WriteLine((decimal)a + userInt);
            Console.ReadLine();


            Console.WriteLine("Now, here's a string converted to a number...");
            string userName = Convert.ToString(Console.ReadLine());
            var isNumeric = int.TryParse(userName, out int n);
            int result2 = n * 10;
            Console.WriteLine("Boom: " + result2);
            Console.ReadLine();

        }
        private double length; //length of a line
        public Program()
        {
            Console.WriteLine("Object is being created");
        }
        public void setLength(double len)
        {
            length = len;
        }
        public double getLength()
        {
            return length;
        }

        static void Main(string[] args)
        {
            MyMethod();

            Program insClass = new Program();

            insClass.setLength(6.0);
            Console.WriteLine("Here is instantiation.", insClass.getLength());
        }
        
    
}
}


//1. Create a class. In that class, create a method that will take in an 
//    integer, do a math operation to it and then return the answer as an integer.

//2. In the Main() method of the console app, instantiate the class and call 
//    the one method, passing in an integer.Display the result to the screen.

//3. Add a second method to the class, with the same name, that will take in 
//a decimal, do a different math operation to it and then return the answer as an integer.

//4. In the Main() method of the console app, instantiate the class and call 
//    the second method, passing in a decimal. Display the result to the screen.

//5. Add a third method to the class, with the same name, that will take in a 
//    string, convert it to an integer if possible, do a different math operation 
//    to it and then return the answer as an integer.

//6. In the Main() method of the console app, instantiate the class and call 
//    the third method, passing in a string that equates to an integer.Display 
//    the result to the screen.
