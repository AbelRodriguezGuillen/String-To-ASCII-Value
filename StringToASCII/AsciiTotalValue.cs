using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringASCIIValues
{
     public class AsciiTotalValue
    {
        public void getAsciiTotalValue(string value)
        {
            OddOrEven oddOrEven = new OddOrEven();
            PrimeNumCheck primeNumCheck = new PrimeNumCheck();
            PalindromeCheck palindromeCheck = new PalindromeCheck();

            byte[] ASCIIvalues = Encoding.ASCII.GetBytes(value.ToCharArray());
            int totalValue = 0;
            foreach (var i in ASCIIvalues)
            {
                totalValue += i;
            }

            Console.WriteLine(totalValue);
            Console.WriteLine();
            oddOrEven.IsOddOrEven(totalValue);
            primeNumCheck.IsPrimeNumCheck(totalValue);
            palindromeCheck.IsPalindromeCheck(totalValue);
        }
    }
}
