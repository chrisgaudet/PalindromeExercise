using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                return false;
            }

            var reversed = "";

            for(int i = word.Length - 1; i >= 0; i--)
            {
                reversed += word[i];
            }

            if(word.ToLower() == reversed.ToLower())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
