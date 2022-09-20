using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringASCIIValues
{
     class Program
    {
        static void Main(string[] args)
        {
            AsciiTotalValue asciiTotalValue = new AsciiTotalValue();
            string readLine;

            do
            {
                Console.Write("To check if the total ASCII value is odd, even, a prime number, or is palindrome, enter a word: ");
                readLine = Console.ReadLine();
                asciiTotalValue.getAsciiTotalValue(readLine);
            }
            while (readLine != "exit");
        }
    }
}
