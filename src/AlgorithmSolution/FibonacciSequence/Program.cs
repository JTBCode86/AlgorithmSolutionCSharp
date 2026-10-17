using System;

class program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter the number of terms in the Fibonacci sequence
        Console.WriteLine("Enter the number of terms in the Fibonacci sequence:");

        // Read the user input and convert it to an integer
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Fibonacci sequence up to {n} terms:");

        // Loop through the number of terms and print each Fibonacci number
        for (int i = 0; i < n; i++)
        {
            Console.Write($"{Fibonacci(i)} ");
        }
    }

    /// <summary>
    /// function to calculate the nth Fibonacci number using recursion       
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    static int Fibonacci(int n)
    {
        // Base case: return n if it is 0 or 1
        if (n <= 1)
            return n;
        else
            // Recursive case: return the sum of the two preceding Fibonacci numbers
            return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}