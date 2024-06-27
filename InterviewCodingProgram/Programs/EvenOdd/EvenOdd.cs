using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCodingProgram.Programs.EvenOdd
{
    internal class EvenOdd
    {
        public static void IsEven(int input)
        {
            // %  modulo operation returns the remainder 4%2 ==0 even
            if (input % 2 == 0)
            {
                Console.WriteLine($"{input} is Even");
            }
            else
            {
                //5 % 2 == 1 odd
                Console.WriteLine($"{input} is Odd");
            }
        }
    }
}
