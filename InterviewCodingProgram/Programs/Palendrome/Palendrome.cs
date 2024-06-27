using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCodingProgram.Programs.Palendrome
{
    internal class Palendrome
    {
        // madam - madam
        //Level - Level
        //approach 1 - reverse the prignam input string and compare it with orignal
        public static void PalendromeUsingNormalWay(string input)
        {
            input = input.ToLower();
            string newInput = string.Empty;
            for (int i = input.Length-1; i >= 0; i--) { 
            
                newInput += input[i];
            }

            var result = input == newInput ? "Palendrome" : "Not Palendrome";
            Console.WriteLine($"{input} is {result}");
        }

        //appraoch 2- compare 1st and last char from string, then 2nd from start and 2nd from last and so on.
        public static void PalendromeUsingOptimizedlWay(string input)
        {
            input = input.ToLower();
            for (int i = 0,j = input.Length - 1; i < j; i++,j--)
            {
                if(input[i] != input[j])
                {
                    Console.WriteLine($"{input} is not palendrome");
                    return;
                }
            }

            Console.WriteLine($"{input} is palendrome");
        }
    }
}
