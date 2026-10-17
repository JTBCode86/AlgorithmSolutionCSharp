using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // Creating an array of integers using the Array class.
        int[] myArry1;
        Array myArry2 = Array.CreateInstance(typeof(int), 5);

        myArry1 = new int[5] { 1, 2, 3, 4, 5 };

        // Setting values in the array using the SetValue method of the Array class.
        myArry2.SetValue(1, 0);
        myArry2.SetValue(2, 1);
        myArry2.SetValue(3, 2);
        myArry2.SetValue(4, 3);
        myArry2.SetValue(5, 4);

        Program p = new Program();
        p.PrintArrayInt(myArry1); 
        p.PrintArray(myArry2);

        Console.ReadLine();
    }

    public void PrintArray(Array arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            //Indexer property of the Array class is used to get the value of the array at the specified index.  
            Console.WriteLine($"Array index {i}: {arr.GetValue(i)}");
        }
    }

    public void PrintArrayInt(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            //Indexer property of the Array class is used to get the value of the array at the specified index.  
            Console.WriteLine($"Int Array index {i}: {arr[i]}");
        }
    }
}