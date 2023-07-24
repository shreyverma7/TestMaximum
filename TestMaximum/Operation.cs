using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaximum
{
    public class Operation
    {
        public void FindMaxInteger(int a, int b, int c)
        {
            if (a >= b && a >= c)
                Console.WriteLine("a in max");
            if (b >= a && b >= c)
                Console.WriteLine("b in max");
            if (c >= b && c >= a)
                Console.WriteLine("c in max");
        }
    }
}
