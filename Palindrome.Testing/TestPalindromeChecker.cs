using System;
using Xunit;
using Palindrome.Logic;

namespace Palindrome.Testing
{
    public class TestPalindromeChecker
    {
        [Fact]
        public void TestCheckString()
        {
            // arrange
            var PC = new PalindromeChecker();
            var expected = true; 
            // act
            var actual = PC.CheckString("anna");

            // assert
            Assert.True(expected == actual);
        }
    }
}