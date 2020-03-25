using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    public struct Number
    {
        public decimal Amount { get; set; }

        public void DecAmount()
        {
            Amount = Decimal.Add(Amount, 3.8m);
        }


        //have it be of data type decimal -- decimal b = 3.8m;
    }
}
