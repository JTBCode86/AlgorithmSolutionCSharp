using System;
using System.Collections.Generic;
using System.Diagnostics;

public class Program
{
    public static void Main(string[] args) 
    {
        Program program = new Program();

        // Gerando um array um pouco maior para notar a diferença de tempo
        int[] nums = { -4, -2, -2, -2, 0, 1, 2, 2, 2, 3, 3, 4, 4, 6 };

        Stopwatch sw = Stopwatch.StartNew();
        var resultBrute = program.ThreeSumBruteForce(nums);
        sw.Stop();

        Console.WriteLine($"[Brute Force] Tempo gasto: {sw.ElapsedMilliseconds} ms (ou {sw.ElapsedTicks} ticks)");

        // --- Medindo a Abordagem Otimizada (Dois Ponteiros) ---
        sw.Restart(); // Reinicia o cronômetro
        var resultOptimized = program.ThreeSum(nums);
        sw.Stop();

        Console.WriteLine($"[Dois Ponteiros] Tempo gasto: {sw.ElapsedMilliseconds} ms (ou {sw.ElapsedTicks} ticks)");
    }

    /// <summary>
    ///  Três Somatório (Brute Force): Encontra todas as combinações únicas de três números em um array que somam zero.   
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

        for (int i = 0; i < nums.Length; i++)
        {
            // Evitar duplicatas
            if (i > 0 && nums[i] == nums[i - 1])
                continue;

            // Passo 2: Usar dois ponteiros para encontrar os pares que somam a -nums[i]
            int left = i + 1;
            int right = nums.Length - 1;

            // Passo 3: Mover os ponteiros para encontrar a soma desejada        
            while (left < right)
            {
                int sum = nums[i] + nums[left] + nums[right];

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