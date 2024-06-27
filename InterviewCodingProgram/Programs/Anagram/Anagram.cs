using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCodingProgram.Programs.Anagram
{
    //An anagram is a word formed by rearranging the letters of another word, 
    //using all the original letters exactly once.
    internal class Anagram
    {
        //"listen" and "silent"
        //"debit card" and "bad credit"
        //"astronomer" and "moon starer"
        public static void IsAnagram(string str1, string str2)
        {
            //remove spaces if any
            string string1 = str1.Replace(" ", "");
            string string2 = str2.Replace(" ", "");

            //if length not equal, not an anagram
            if (string1.Length != string2.Length)
            {
                Console.WriteLine($"{str1} & {str2} are not anagram.");
            }

            // gets char array from string
            char[] char1 = string1.ToCharArray();
            char[] char2 = string2.ToCharArray();

            //Sort the array
            Array.Sort(char1);
            Array.Sort(char2);

            // create new string from sorted char array
            string newstr1 = new string(char1);
            string newstr2 = new string(char2);

            // compare both strings for equality
            if (newstr1 == newstr2)
            {
                Console.WriteLine($"{str1} & {str2} are anagram.");
            }
        }
    }
}
