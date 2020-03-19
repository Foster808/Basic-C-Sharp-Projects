using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_INT_2
{
    public class Pass
    {
        public void MyMethod(int x, int y = 8)
        //public void MyMethod(int x, int y = 8);
        {
            

            int input = x;
            int input2 = y;

            Console.WriteLine("Your numbers added: " + (x + y));
            
        }

        
       
    }
}
