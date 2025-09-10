// -----------------------------------------------------------------------------
// Problem: Sum Without Highest and Lowest Number
// -----------------------------------------------------------------------------
// Task:
// Given an array (or list) of numbers, return the sum of all elements 
// except the highest and lowest values (by value, not by index).

// Example 1:
// Input: [6, 2, 1, 8, 10]
// Sorted → [1, 2, 6, 8, 10]
// Remove lowest (1) and highest (10)
// Remaining sum = 2 + 6 + 8 = 16
//
// Explanation:
// - Loop once through the array
// - Track sum, min, and max
// - Final result = total - min - max
// - Efficient: O(n) time, O(1) space
// -------------------------------------------------------------

using System;

public class Program
{
    // Function to calculate sum excluding one min and one max value
    public static int SumWithoutHighestAndLowest(int[] numbers)
    {
        // Step 1: Input validation
        if (numbers == null || numbers.Length <= 2)
        {
            return 0;
        }

        // Step 2: Initialize tracking variables
        int totalSum = 0;
        int minValue = int.MaxValue;
        int maxValue = int.MinValue;

        // Step 3: Single pass to calculate sum, min, and max
        foreach (int num in numbers)
        {
            totalSum += num;

            if (num < minValue)
                minValue = num;

            if (num > maxValue)
                maxValue = num;
        }

        // Step 4: Subtract one min and one max
        return totalSum - minValue - maxValue;
    }

    public static void Main(string[] args)
    {
        // Example test cases      
        Console.WriteLine(SumWithoutHighestAndLowest(new int[] { 5, 5 }));            // Expected: 0
        Console.WriteLine(SumWithoutHighestAndLowest(new int[] { 10, 10, 10 }));      // Expected: 10
    }
}
