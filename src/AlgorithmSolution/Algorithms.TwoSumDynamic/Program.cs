using System;

class program   {
    static void Main(string[] args)
    {
        Console.WriteLine("=== Two Sum Challenge ===");

        // Prompt the user to enter an array of integers and a target value
        Console.WriteLine("Enter an array of integers (comma-separated, ex: 2 7 11 15): ");
        string inputNums = Console.ReadLine();

        Console.WriteLine("Enter the target sum: ");
        int target = int.Parse(Console.ReadLine());

        // Convert the input string to an array of integers
        int[] nums = Array.ConvertAll(inputNums.Split(' '), int.Parse);

        try
        {
            // Call the TwoSum method to find the indices of the two numbers that add up to the target
            int[] result = TwoSum(nums, target);
            Console.WriteLine($"\nIndices found: [{result[0]}, {result[1]}]");
            Console.WriteLine($"\r\nCorresponding values: {nums[result[0]]} + {nums[result[1]]} = {target}");
        }
        catch (Exception ex)
        {
            // Handle any exceptions that may occur during the execution of the TwoSum method
            Console.WriteLine($"\nError: {ex.Message}");
        }
    }

    static int[] TwoSum(int[] nums, int target)
    {
        // Create a dictionary to store the indices of the numbers we have seen so far
        Dictionary<int, int> map = new Dictionary<int, int>();

        // Iterate through the array of numbers
        for (int i = 0; i < nums.Length; i++)
        {
            // Calculate the complement of the current number with respect to the target
            int complement = target - nums[i];

            // Check if the complement exists in the dictionary
            if (map.ContainsKey(complement))
            {
                // If it exists, return the indices of the two numbers
                return new int[] { map[complement], i };
            }

            // If the current number is not already in the dictionary, add it with its index
            if (!map.ContainsKey(nums[i]))
            {
                // Add the current number and its index to the dictionary
                map.Add(nums[i], i);
            }

        }

        throw new Exception("No two sum solution found.");

    }
}