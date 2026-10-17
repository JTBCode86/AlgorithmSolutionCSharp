using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        int[] nums = { 1, 1, 0, 1, 1, 1, 0, 1 };
        Program p = new Program();
        var result = p.FindMaxConsecutiveOnes(nums);

        Console.WriteLine($"The maximum number of consecutive 1's is: {result}");

    }

    public int FindMaxConsecutiveOnes(int[] nums) 
    {
        int maxStreak = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            // If we encounter a 1, we start counting the streak of consecutive 1's
            if (nums[i] == 1)
            {
                int currentStreak = 0;
                while (i < nums.Length && nums[i] == 1)
                {
                    currentStreak++;
                    i++;
                }
                maxStreak = Math.Max(maxStreak, currentStreak);
            }
        }

        return maxStreak;
    }
}