/*
Codewars Challenge: Convert number to reversed array of digits

Problem:
Given a number, return the digits of this number in reverse order as an array.

Example:
Input:  35231
Output: [1, 3, 2, 5, 3]

------------------------------------------------------
1. Extract the last digit using modulo (%) → n % 10
2. Remove the last digit using division (/) → n / 10
3. Append each digit to a list (digits naturally come reversed).
4. Convert the list to an array and return.

------------------------------------------------------
*/

using System;
using System.Collections.Generic;

public class Kata
{
    public static long[] Digitize(long n)
    {
        List<long> digits = new List<long>();

        // Edge case: if number is 0, just return [0]
        if (n == 0) return new long[] { 0 };

        // Extract digits until the number becomes 0
        while (n > 0)
        {
            digits.Add(n % 10); // take last digit
            n /= 10;            // remove last digit
        }

        return digits.ToArray(); // return as array
    }
}

// Example test:
//Console.WriteLine(string.Join(",", Kata.Digitize(35231))); // Output: 1,3,2,5,3
