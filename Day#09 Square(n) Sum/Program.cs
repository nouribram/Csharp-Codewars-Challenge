/*
 Given an array of integers, return the sum of their squares.

 Example:
   Input: [1, 2, 3]
   Output: 1² + 2² + 3² = 14

 ---------------------------
  Steps
 ---------------------------- 
 1. Receive an array of integers.
 2. For each integer, square it (n * n).
 3. Add all squared values together.
 4. If the array is null or empty, return 0.
 5. Use a simple loop for performance (O(n) time).
 6. Return the final result as an int (as required by Codewars).


*/
using System;


public static class Kata
{
    public static int SquareSum(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            return 0;

        int sum = 0; 

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i] * numbers[i];
        }

        return sum; 
    }

    public static void Main()
    {
        Console.WriteLine(SquareSum(new[] { 1, 2, 3 }));   /* Expected: 14 */
        Console.WriteLine(SquareSum(new[] { 0, -1, -2 })); /* Expected: 5  */
        Console.WriteLine(SquareSum(null));                /* Expected: 0  */
    }
}
