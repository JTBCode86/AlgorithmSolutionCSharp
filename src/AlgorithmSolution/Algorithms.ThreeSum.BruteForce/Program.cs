using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        int[] nums = { -1, 0, 1, 2, -1, -4 };

        // Testando a versão Brute Force
        var result = program.ThreeSumBruteForce(nums);

        Console.WriteLine("Trincas encontradas (Brute Force):");
        foreach (var triplet in result)
        {
            Console.WriteLine($"[{string.Join(", ", triplet)}]");
        }
    }

    /// <summary>
    /// Três Somatório (Brute Force): Encontra todas as combinações únicas de três números em um array que somam zero usando uma abordagem de força bruta.   
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public IList<IList<int>> ThreeSumBruteForce(int[] nums) 
    {
        // Usando um HashSet para evitar duplicatas
        var resultSet = new HashSet<string>();
        var result = new List<IList<int>>();

        int n = nums.Length;

        // Três loops aninhados para verificar todas as combinações possíveis
        for (int i = 0; i < n - 2; i++) 
        {
            for (int j = i + 1; j < n - 1; j++) 
            {
                for (int k = j + 1; k < n; k++) 
                {
                    if (nums[i] + nums[j] + nums[k] == 0) 
                    {
                        // Ordenar a tripla para evitar duplicatas
                        var triplet = new List<int> { nums[i], nums[j], nums[k] };
                        triplet.Sort();

                        string tripletKey = string.Join(",", triplet);
                        
                        if (!resultSet.Contains(tripletKey)) 
                        {
                            resultSet.Add(tripletKey);
                            result.Add(triplet);
                        }
                    }
                }
            }
        }
        return result;
    }
}
