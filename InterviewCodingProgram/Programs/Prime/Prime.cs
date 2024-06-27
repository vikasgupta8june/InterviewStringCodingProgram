using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCodingProgram.Programs.Prime
{
    internal class Prime
    {
        //A prime number is a positive integer that is divisible only by itself and 1
        //2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, ...
        public static void IsPrime(int input)
        {
            for (int i = 2; i < input/2; i++)
            {
                //if remainder 0 then its not prime
                if(input % i == 0)
                {
                    Console.WriteLine($"{input} is not a prime number.");
                    return;
                }
            }
            Console.WriteLine($"{input} is a prime number.");
        }
    }
}
