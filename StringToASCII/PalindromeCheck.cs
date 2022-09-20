using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringASCIIValues
{
    public class PalindromeCheck
    {
        public void IsPalindromeCheck(int totalValue)
        {
            int reverse = 0;
            while (totalValue > 0)
            {
                reverse = reverse * 10 + totalValue % 10;
                totalValue = totalValue / 10;
            }
            Console.WriteLine($"The ASCII value reveresed is: {reverse}");

            if (totalValue == reverse)
            {
                Console.WriteLine("Total value is Palindrome.\n");
            }

            if (totalValue != reverse)
            {
                Console.WriteLine("Total value is not Palindrome.\n");
            }
        }
    }

}
