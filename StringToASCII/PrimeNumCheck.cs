using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringASCIIValues
{
    public class PrimeNumCheck
    {
        public void IsPrimeNumCheck(int totalValue)
        {
            // CHECK IF PRIME
            int a = 0;
            for (int i = 1; i <= totalValue; i++)
            {
            if (totalValue % i == 0)
            {
                a++;
            }
        }

            if (a == 2)
            {
                Console.WriteLine("{0} is a Prime Number", totalValue);
            }
            else
            {
                Console.WriteLine("Not a Prime Number");
            }

        }
    }
}
