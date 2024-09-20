using PalindromeExercise;
using System;
using System.Security.Cryptography.X509Certificates;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
       
        [Theory]
        [InlineData("dad", true)]
        [InlineData("level", true)]
        [InlineData("rotator", true)]
        [InlineData("civic", true)]
        [InlineData("hello", false)]
        [InlineData("", false)]
        [InlineData(null, false)]

        public void PalindromeTest(string word, bool expected)
        {
            //Arrange
            var wordSmith = new WordSmith();

            //Act
            var actual = wordSmith.IsAPalindrome(word);

            //Assert
            Assert.Equal(expected, actual);
        }
        
    }
}
