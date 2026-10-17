using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter a number
        Console.WriteLine("Enter the number of Factorial:");
        int n = int.Parse(Console.ReadLine());

        // Calculate the factorial using recursion
        int result = Factorial(n);
        Console.WriteLine($"Factorial of {n} is: {result}");

    }
    /// <summary>
    ///  Recursively calculates the factorial of a given number n.
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    static int Factorial(int n)
    {
        // Base case
        if (n <= 1)
            return 1;

        // Recursive case
        return n * Factorial(n - 1);

    }
}
