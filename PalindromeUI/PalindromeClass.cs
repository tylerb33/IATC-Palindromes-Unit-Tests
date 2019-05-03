using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace PalindromeUI
{
    public class PalindromeClass
    {
        public static bool CheckIfPalindrome(int number)
        {
            return CheckIfPalindrome(number.ToString());
        }

        public static bool CheckIfPalindrome(string wordToTest)
        {
            Regex charactersWeCareToCheck = new Regex("[^a-zA-Z0-9]");
            wordToTest = charactersWeCareToCheck.Replace(wordToTest, "");
            wordToTest = wordToTest.ToUpper();

            char[] backwards = wordToTest.Reverse().ToArray();
            char[] forwards = wordToTest.ToCharArray();

            string backwardsText = new string(backwards);

            bool output = (string.Compare(backwardsText, wordToTest) == 0);
            return output;

        }

    }
}
