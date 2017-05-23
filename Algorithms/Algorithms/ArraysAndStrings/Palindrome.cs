using System;

namespace Algorithms.ArraysAndStrings
{
    public class Palindrome
    {

        public bool PalindromeExample(string myString)
        {
            var length = myString.Length;
            var halfLength = length / 2;

            for (int i = 0; i < halfLength; i++)
            {
                var s = myString[i];
                var s1 = myString[length - i - 1];

                if (myString[i] != myString[length - i - 1])
                {
                    Console.WriteLine(myString + " is not palindrome");
                    return false;
                }
            }

            Console.WriteLine(myString + " is palindrome");
            return true;
        }
    }
}
