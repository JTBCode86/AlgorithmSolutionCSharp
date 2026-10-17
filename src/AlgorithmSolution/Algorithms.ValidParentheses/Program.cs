using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter a sequence of characters to validate
        Console.WriteLine("=== Valid Parentheses Challenge ===");
        Console.WriteLine("Enter the sequence of characters to validate (e.g., {[()]}): ");

        // Read the user input
        string input = Console.ReadLine();

        // Call the IsValid method to check if the input string has valid parentheses/braces
        if (IsValid(input))
        {
            Console.WriteLine("Result: VALID! All parentheses/braces close in the correct order.");
        }
        else
        {
            Console.WriteLine("Result: INVALID! The structure is incorrect.");
        }

    }
    /// <summary>
    ///  Implement a method to check if the input string has valid parentheses/braces.
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    static bool IsValid(string s)
    {
        // Use a stack to keep track of opening brackets
        Stack<char> stack = new Stack<char>();

        // Iterate through each character in the input string
        foreach (char c in s)
        {
            if (c == '(' || c == '{' || c == '[') // If it's an opening bracket, push it onto the stack
            {
                stack.Push(c);
            }
            else if (c == ')' || c == '}' || c == ']') // If it's a closing bracket, check for a matching opening bracket
            {
                if (stack.Count == 0) // If the stack is empty, there's no matching opening bracket
                {
                    return false; // No matching opening bracket
                }
                char top = stack.Pop(); // Pop the top of the stack and check if it matches the closing bracket
                if ((c == ')' && top != '(') ||
                    (c == '}' && top != '{') ||
                    (c == ']' && top != '['))
                {
                    return false; // Mismatched brackets
                }
            }
        }
        return stack.Count == 0; // Valid if no unmatched opening brackets remain
    }
}
