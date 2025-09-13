/*
 Smash Problem
===================================
 Problem:
 Write a function that takes an array of words and smashes them together into a sentence
 and returns the sentence. You can ignore any need to sanitize words or add punctuation,
 but you should add spaces between each word.
 Be careful: there shouldn't be a space at the beginning or the end of the sentence!

 Example:
   Smash(new string[] { "hello", "world" }) ➞ "hello world"

 Approach:
 - Use string.Join(" ", words) in C# to combine words with a single space between them.
 - This automatically avoids leading/trailing spaces.
*/

using System;

class Program
{
    // Function to smash words into a sentence
    public static string Smash(string[] words)
    {
        // Join words with a single space
        return string.Join(" ", words);
    }

    static void Main(string[] args)
    {
        // Test cases
        Console.WriteLine(Smash(new string[] { "I", "love", "coding" }));  // Output: "I love coding"
    }
}
