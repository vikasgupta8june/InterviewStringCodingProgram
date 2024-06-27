using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCodingProgram.Programs.Fibonacci
{
    internal class Fibonacci
    {
        // n = 6 , n means upto what number
        // 0,1,1,2,3,5
        public static void FibonacciSeries(int n)
        {
            int a = 0;
            int b = 1;
            Console.Write($"Fibonacci series: {a},{b}");
            for (int i = 0; i < n - 2; i++)
            {
                int c = a + b;
                Console.Write($",{c}");
                a = b;
                b = c;
            }
        }
    }
}
