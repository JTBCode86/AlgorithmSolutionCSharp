using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter an array of integers and a target value
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;

        // Call the TwoSum function and print the result
        int[] result = TwoSum(nums, target);
        
        // Print the result
        if (result != null)
        {
            Console.WriteLine($"Indices: {result[0]}, {result[1]}");
        }
        else
        {
            Console.WriteLine("No solution found.");
        }
    }
    /// <summary>
    ///  This function takes an array of integers and a target integer as input, and returns the indices of the 
    ///  two numbers in the array that add up to the target. It uses a dictionary to store the numbers and their 
    ///  corresponding indices for efficient lookup.  
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    static int[] TwoSum(int[] nums, int target)
    {
        // Create a dictionary to store the numbers and their indices
        Dictionary<int, int> numToIndex = new Dictionary<int, int>();

        // Iterate through the array of numbers
        for (int i = 0; i < nums.Length; i++)
        {
            // Calculate the complement of the current number with respect to the target
            int complement = target - nums[i];

            // Check if the complement exists in the dictionary
            if (numToIndex.ContainsKey(complement))
            {
                // If it exists, return the indices of the two numbers
                return new int[] { numToIndex[complement], i };
            }
            // If the current number is not already in the dictionary, add it with its index
            if (!numToIndex.ContainsKey(nums[i]))
            {
                // Add the current number and its index to the dictionary
                numToIndex[nums[i]] = i;
            }
        }
        return null; // No solution found
    }
}

