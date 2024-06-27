using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCodingProgram.Programs.StringManipulation
{
    internal class StringProgram
    {
        //Count characters or character frequency in string
        //India - I-2 N-1 D-1 A-1
        public static void CharacterFrequencyCount(string str)
        {
            str = str.ToLower();

            //a Dictionary<TKey, TValue> is a collection that stores key-value pairs, providing fast lookups
            //Each key in the Dictionary must be unique.
            Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();

            foreach (char ch in str)
            {
                if (keyValuePairs.ContainsKey(ch))
                {
                    keyValuePairs[ch]++;
                }
                else
                {
                    keyValuePairs.Add(ch, 1);
                }
            }

            foreach (var ch in keyValuePairs)
            {
                Console.Write($"{ch.Key}{ch.Value} ");
            }
        }

        //Remove duplicate charaters from string
        //India   Inda
        public static void RemoveDuplicateCharInString(string str)
        {
            str = str.ToLower();
            string result = string.Empty;
            foreach (char ch in str)
            {
                if (!result.Contains(ch))
                {
                    result += ch;
                }
            }

            Console.WriteLine($"After removing duplicate from {str} is {result}");
        }

        // find all possible substring of a given string
        //abcd
        //a ab ac ad b bc bd c cd d
        public static void FindAllSubstring(string str)
        {
                for (int i = 0; i < str.Length; i++)
                {
                    Console.Write(str[i].ToString() + ",");
                    string temp = str[i].ToString();
                    for (int j = i + 1; j < str.Length; j++)
                    {
                        temp += str[j];
                        Console.Write(temp.ToString() + ",");
                    }

                    Console.WriteLine();
                }            
        }

        //Reverse each character in string
        //01234        
        //Hello  - olleH

        public static void ReverseStringUsingNormalWay(string str)
        {
            string result = string.Empty;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                result += str[i];
            }

            Console.WriteLine($"Reverse of {str} is {result}");
        }

        //Reverse each character in string
        //01234
        //Hello  - olleH
        public static void ReverseStringInEfficientWay(string str)
        {
            StringBuilder result = new StringBuilder(str);
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                char temp = result[i];
                result[i] = result[j];
                result[j] = temp;

            }

            Console.WriteLine($"Reverse of {str} is {result}");
        }

        //How to reverse each word in a given sentence
        // 0     1  2
        //India is great  -  great is India
        public static void ReverseWordsInSentence(string str)
        {
            string[] strArray = str.Split(" ");
            string result = string.Empty;
            for (int i = strArray.Length - 1; i >= 0; i--)
            {
                result += " " + strArray[i];
            }

            Console.WriteLine($"Reverse of {str} is {result}");
        }


        //Note:string are immutable so u can't swap its char position, instead can append
        //string a = "1ww";
        //string b = "1ww";
        //string c = a[0] + b[0];
    }
}
