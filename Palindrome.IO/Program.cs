using System;
using Palindrome.Logic;

namespace Palindrome.IO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MessWithPalindromeChecker();
        }

        /**
        a palindrome is a word or sentence that read forward or backward result in the same word or sentence. example: civic, anana, never odd or even.
        write a solution that given an input can determine if it is a palindrome or not.
        you are open to use notes and online resources, except each other.
         */
        private static void MessWithPalindromeChecker() 
        {
            PalindromeChecker PC = new PalindromeChecker();
            Console.WriteLine(PC.CheckString("anna"));
        }
    }
}
