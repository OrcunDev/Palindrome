using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Palindrome
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //Reading user input
                Console.Write("Please, enter your word to check if it is Palindrome or not:");
                string msg = Console.ReadLine();
                string msgLowerCase = msg.ToLower();
                if (msgLowerCase.Length>=1 && IsPalindrome(msgLowerCase) == true)
                {
                    Console.WriteLine(msg + " is a Palindrome...");
                }
                else
                {
                    Console.WriteLine(msg + " is not a Palindrome!");
                }
                Console.WriteLine("Do you want to exit the program?/n type 'E' to Exit or 'C' to Continue! ");
                string userAnswer = Console.ReadLine();
                if (userAnswer =="E")
                {
                    break;
                }
            }
        }

        static bool IsPalindrome(string userInput)
        {
            bool equalityResult = false;
            try
            {
                char[] originalArray = userInput.ToCharArray();
                char[] chArray = userInput.ToCharArray();  // Use ToCharArray to convert string to array.
                char[] reversed = ArrayReverse(chArray);
                equalityResult = originalArray.SequenceEqual(reversed);               
            }
            catch(IOException e)
            {
                Console.WriteLine("There is an error in checking Palindrome!!!");
            }
            return equalityResult;
        }
    
        static char[] ArrayReverse(char[] arr)
        {
            try
            {
                Array.Reverse(arr);
                return arr;
            }
            catch(IOException e)
            {
                Console.WriteLine(" There is an error during the reversing the array!!!");
            }
            return arr;
        }

    }
}
