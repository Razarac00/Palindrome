using System;
using Xunit;
using Palindrome.Logic;

namespace Palindrome.Testing
{
    public class TestPalindromeChecker
    {

        [Fact]
        public void TestCheckTrueNullString()
        {
            // arrange
            var PC = new PalindromeChecker();
            var expected = true; 
            // act
            var actual = PC.CheckString("");

            // assert
            Assert.True(expected == actual);
        }

        [Fact]
        public void TestCheckStringTrueBasic()
        {
            // arrange
            var PC = new PalindromeChecker();
            var expected = true; 
            // act
            var actual = PC.CheckString("anna");

            // assert
            Assert.True(expected == actual);
        }

        [Fact]
        public void TestCheckStringFalseBasic()
        {
            // arrange
            var PC = new PalindromeChecker();
            var expected = true; 
            // act
            var actual = PC.CheckString("fred");

            // assert
            Assert.False(expected == actual);
        }

        [Fact]
        public void TestCheckStringTrueAdvanced()
        {
            // arrange
            var PC = new PalindromeChecker();
            var expected = true; 
            // act
            var actual = PC.CheckString("wol low");

            // assert
            Assert.True(expected == actual);
        }

        [Fact]
        public void TestCheckStringFalseAdvanced()
        {
            // arrange
            var PC = new PalindromeChecker();
            var expected = true; 
            // act
            var actual = PC.CheckString("I cant think of any good long palindrome sentences");

            // assert
            Assert.False(expected == actual);
        }

        [Fact]
        public void TestCheckStringFalseWhiteSpace()
        {
            // arrange
            var PC = new PalindromeChecker();
            var expected = true; 
            // act
            var actual = PC.CheckString("  1 ");

            // assert
            Assert.False(expected == actual);
        }

    }
}