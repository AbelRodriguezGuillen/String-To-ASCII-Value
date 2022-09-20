using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringASCIIValues
{
    public class OddOrEven
    {
        public void IsOddOrEven(int totalValue)
        {

            if (totalValue % 2 == 0)
            {
                Console.WriteLine("The total ASCII value is even");
            }
            else
            {
                Console.WriteLine("The total ASCII value is odd");
            }
        }
    }
}
