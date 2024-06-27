using InterviewCodingProgram.Programs.Anagram;
using InterviewCodingProgram.Programs.Factorial;
using InterviewCodingProgram.Programs.Fibonacci;
using InterviewCodingProgram.Programs.Palendrome;
using InterviewCodingProgram.Programs.Prime;
using InterviewCodingProgram.Programs.StringManipulation;

namespace InterviewCodingProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //StringProgram.CharacterFrequencyCount("India");
            //StringProgram.RemoveDuplicateCharInString("India");
            //StringProgram.FindAllSubstring("abcd");
            //StringProgram.ReverseStringUsingNormalWay("Hello");
            StringProgram.ReverseStringInEfficientWay("Hello");
            StringProgram.ReverseWordsInSentence("India is great");


            Anagram.IsAnagram("listen", "silent");
            Anagram.IsAnagram("debit card", "bad credit");
            Anagram.IsAnagram("astronomer", "moon starer");
            Console.WriteLine("");




















            int factInput = 5;
            Console.WriteLine($"Factorial of {factInput} is {Factorial.FactorialWithoutRecursion(5)}");
            Console.WriteLine($"Factorial of {factInput} is {Factorial.FactorialWithRecursion(5)}");

            string palendromeInput = "Madam";
            Palendrome.PalendromeUsingNormalWay(palendromeInput);
            Palendrome.PalendromeUsingOptimizedlWay(palendromeInput);

            string notPalendromeInput = "Rocket";
            Palendrome.PalendromeUsingNormalWay(notPalendromeInput);
            Palendrome.PalendromeUsingOptimizedlWay(notPalendromeInput);

            int fibonacciInput = 6;
            Fibonacci.FibonacciSeries(fibonacciInput);

            int primeNumInput = 6;
            Prime.IsPrime(primeNumInput);

          

           
        }
    }
}
