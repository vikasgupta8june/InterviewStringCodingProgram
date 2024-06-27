using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCodingProgram.Programs.Factorial;

internal class Factorial
{
    //O(n)
    //input 5
    //step 1: i(1)<=input(5) fact = 1(fact) * i(1)=1
    //step 2: i++ i(2)<=input(5) fact = 1(fact) * i(2)=2
    //step 3: i++ i(3)<=input(5) fact = 2(fact) * i(3)=6
    //step 4: i++ i(4)<=input(5) fact = 6(fact) * i(4)=24
    //step 5: i++ i(5)<=input(5) fact = 24(fact) * i(5)=120
    public static int FactorialWithoutRecursion(int input)
    {
        //factorial of 0! is 1.
        if (input == 0)
        {
            return 1;
        }

        int fact = 1;
        for (int i = 1; i <= input; i++)
        {
            fact *= i;
        }

        return fact;
    }

    //input 5
    //step 1 return 5 * (5-1)
    //step 2 return 5 * 4 *(4-1)
    //step 3 return 5 * 4 * 3  * (3-1)
    //step 4 return 5 * 4 * 3 * 2 * (2-1)
    //step 5 return 5 * 4 * 3 * 2 * 1 * (1-1)
    //step 6 return 5 * 4 * 3 * 2 * 1 * 1(return 0)
    public static int FactorialWithRecursion(int input)
    {
        if(input == 0) { return 1; }
        else
        {
            return input * FactorialWithRecursion(input - 1);
        }
    }
}  
