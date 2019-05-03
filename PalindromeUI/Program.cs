using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeUI
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepAsking = true;

            do
            {
            Console.WriteLine("Enter a text to check: ");
            string userInput = Console.ReadLine();

            //PalindromeClass myPalindromeClass = new PalindromeClass();
            Console.WriteLine(PalindromeClass.CheckIfPalindrome(userInput));

                do
                {
                    keepAsking = AskIfUserWantsToContinue();
                } while ( !(keepAsking == true || keepAsking == false));
            
            } while (keepAsking);

            Console.WriteLine("Thanks for participating. Press any key to exit.");
            Console.ReadLine();
        }

        private static bool AskIfUserWantsToContinue()
        {
            Console.WriteLine("Do you want to try another text? (Y/N)");
            string askAgain = Console.ReadLine().ToUpper();

            if (askAgain == "Y")
            {
                return true;
            }
            else if (askAgain == "N")
            {
                return false;

            }
            return false;
        }
    }
}
