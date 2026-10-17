using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Program program = new Program();

        int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
        int k = 3;

        program.Rotate(nums, k);

        // Output the rotated array
        Console.WriteLine("Array rotacionado:");
        Console.WriteLine(string.Join(", ", nums));
        Console.ReadKey();
    }

    /// <summary>
    /// // Rotaciona o array para a direita em k passos, onde k é não negativo.
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="k"></param>
    public void Rotate(int[] nums, int k) 
    {
        if (nums == null || nums.Length <=1)
            return;
        
        k = k % nums.Length; // Handle cases where k is greater than the length of the array
        
        if (k == 0) 
            return;

        // Step 1: Reverse the first part of the array
        Reverse(nums, 0, nums.Length - 1); // Reverse the entire array

        // Step 2: Reverse the first k elements
        Reverse(nums, 0, k - 1);

        // Step 3: Reverse the remaining elements
        Reverse(nums, k, nums.Length - 1);

    }

    /// <summary>
    ///  // Reverses a portion of the array from the start index to the end index.   
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="start"></param>
    /// <param name="end"></param>
    private void Reverse(int[] nums, int start, int end) 
    {
        while (start < end) 
        {
            int temp = nums[start];
            nums[start] = nums[end];
            nums[end] = temp;
            start++;
            end--;
        }
    }
}