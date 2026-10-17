using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        int[] nums = { 1, 1, 2, 2, 3, 4, 4, 5 };
        Program program = new Program();

        int newLength = program.RemoveDuplicates(nums);
        Console.WriteLine("New length: " + newLength);
        Console.WriteLine("Array after removing duplicates:");
        for (int i = 0; i < newLength; i++)
        {
            Console.Write(nums[i] + " ");
        }
        Console.ReadLine();
    }

    public int RemoveDuplicates(int[] nums) 
    {
        if (nums.Length==0)
        {
            return 0;
        }

        int i = 0;
        for (int j = 1; j < nums.Length; j++) 
        {
            if (nums[j] != nums[i]) 
            {
                i++;    // Incrementa o índice i para a próxima posição única
                nums[i] = nums[j]; // Move o próximo número único para a posição i
            }
        }
        return i + 1;
    }
}