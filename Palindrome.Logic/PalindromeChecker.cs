using System;

namespace Palindrome.Logic
{
    public class PalindromeChecker
    {

        private string formatSentence(string stringToCheck)
        {
            return stringToCheck.ToLower();
        }

        private string reverseSentence(string stringToReverse)
        {
            char[] result = stringToReverse.ToCharArray();
            Array.Reverse(result);
            return new string(result);
        }

        public bool CheckString(string stringToCheck)
        {
            string loweredString = formatSentence(stringToCheck);
            
            return reverseSentence(loweredString).Equals(loweredString);
        }

        public PalindromeChecker() 
        {
        }
    }
}