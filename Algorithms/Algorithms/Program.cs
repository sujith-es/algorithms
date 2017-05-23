namespace Algorithms
{
    using System;

    using Algorithms.ArraysAndStrings;

    public class Program
    {
        public static void Main(string[] args)
        {
            // Un-Comment below block and run.

            // ************** START: Find if string has unique characters.
            // StringHasUniqueCharacters uniqueCharacters = new StringHasUniqueCharacters();
            // var uniqeSetWord = "unique characters";
            // var result = uniqueCharacters.IsUniqueChars(uniqeSetWord);
            // Console.WriteLine("Uniqu key result for word {0} is {1}", uniqeSetWord, result);

            // ************** END:Find if string has unique characters.


            // ************** START: Palindrom - One of best solution
            Palindrome palindrome = new Palindrome();
            palindrome.PalindromeExample("malayalam");

            // ************** END: Palindrom - One of best solution
            Console.ReadKey();
        }
    }
}
