using System;
using System.Collections.Generic;

public class  Program
{
    public static void Main()
    {
        Program program = new Program();
        int[] nums = { -1, 0, 1, 2, -1, -4 };

        // Call the ThreeSum method
        var result = program.ThreeSum(nums);
        
        // Print the result
        Console.WriteLine("Trincas encontradas:");
        foreach (var triplet in result)
        {
            Console.WriteLine($"[{string.Join(", ", triplet)}]");
        }
    }

    /// <summary>
    /// Três Somatório (Dois Ponteiros): Encontra todas as combinações únicas de três números em um array que somam zero usando a técnica de dois ponteiros.
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        var result = new List<IList<int>>();

        // Passo 1: Ordenar o array
        Array.Sort(nums);

        // Passo 2: Iterar sobre o array
        for (int i = 0; i < nums.Length; i++)
        {
            // Evitar duplicatas
            if (i > 0 && nums[i] == nums[i - 1])
                continue;

            // Passo 2.2: Usar dois ponteiros para encontrar os pares que somam a -nums[i]
            int left = i + 1;
            int right = nums.Length - 1;

            // Passo 3: Mover os ponteiros para encontrar a soma desejada        
            while (left < right)
            {
                // Calcular a soma dos três números
                int sum = nums[i] + nums[left] + nums[right];

                // Se a soma for zero, adicionamos a tripla ao resultado
                if (sum == 0)
                {
                    result.Add(new List<int> { nums[i], nums[left], nums[right] });

                    // Evitar duplicatas
                    while (left < right && nums[left] == nums[left + 1]) 
                        left++;

                    // Evitar duplicatas
                    while (left < right && nums[right] == nums[right - 1]) 
                        right--;

                    left++;
                    right--;
                }
                else if (sum < 0)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
        }
        return result;
    }
}