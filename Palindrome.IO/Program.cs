using System;
using Palindrome.Logic;
using System.Collections.Generic;

namespace Palindrome.IO
{
    class Program
    {
        static void Main(string[] args)
        {

            MessWithPalindromeChecker();
        }

        private static void MessWithPalindromeChecker() 
        {
            PalindromeChecker PC = new PalindromeChecker();
            List<string> TestThese = new List<string> {"anna", "Anna", "aNnA", "girafarig"};

            TestThese.Add("greg"); 
            TestThese.Add("the dishwasher"); 
            TestThese.Add("put that down");
            TestThese.Add("");
            TestThese.Add("ciViC duty Ytud ciVIC");
            TestThese.Add("   0   ");
            TestThese.Add("  1 ");


            foreach (string sentence in TestThese)
            {
                Console.WriteLine(PC.CheckString(sentence));
            }




            
        }
    }
}
