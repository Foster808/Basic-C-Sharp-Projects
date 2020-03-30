using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch
{
    public class wrongNumber : Exception
    {
        public wrongNumber()
            : base() { }
        public wrongNumber(string message)
            : base(message) { }
    }
}
