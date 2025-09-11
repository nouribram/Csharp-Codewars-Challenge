/*
Convert a String to a Number!
_________________________________________

Problem:
Convert a string into a number.

Examples:
"1234" -> 1234
"605"  -> 605
"-7"   -> -7

Steps / Explanation:

1- We need a method that takes a string as input.
2- The string is guaranteed to be a valid integer.
3- We can use C#'s built-in method `int.Parse` to convert the string to an integer.
4- `int.Parse(str)` reads the string and returns the integer value.
   - Example: int.Parse("1234") returns 1234
   - Example: int.Parse("-7") returns -7
5- Since input is guaranteed valid, we don't need extra checks or error handling.
6- We can write the method as a single-line expression for simplicity and readability.
*/

public class Kata
{
    // Method to convert string to number
    public static int StringToNumber(string str) 
        => int.Parse(str); // Converts the string to an integer
}
