using System;

namespace Palindrome_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Takes user input
            // Loops through each letter
            // Checks if backwards position is the same as current position
            // if loop finishes, then you have a palindrome
            // if a letter is different, then it is not a palindrome. Hint use a bool!!!!

            Console.Write("Please enter a word: ");
            string word = Console.ReadLine().ToLower();

            bool isPailindrome = true;
            for (int count = 0; count < word.Length; count++)
            {
                if (word[count] != word[word.Length-1 - count])
                {
                    isPailindrome = false;
                }
            }

            if (isPailindrome == false)
            {
                Console.WriteLine("This word is not a palindrome.");
            }
            else
            {
                Console.WriteLine("This word is a palindrome.");
            }

            Console.ReadLine();

        }
    }
}
