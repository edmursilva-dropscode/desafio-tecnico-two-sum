using System;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                // verifica se a soma dos dois números é igual ao target
                if (nums[i] + nums[j] == target)
                {
                    return new int[] { i, j };
                }
            }
        }
        return new int[] { };
    }
}

class Program
{
    static void Main()
    {
        Solution solution = new Solution();

        // Teste com exemplo 1
        int[] nums1 = { 2, 7, 11, 15 };
        int target1 = 9;
        int[] result1 = solution.TwoSum(nums1, target1);
        Console.WriteLine($"Exemplo 1: [{result1[0]}, {result1[1]}]");

        // Teste com exemplo 2
        int[] nums2 = { 3, 2, 4 };
        int target2 = 6;
        int[] result2 = solution.TwoSum(nums2, target2);
        Console.WriteLine($"Exemplo 2: [{result2[0]}, {result2[1]}]");

        // Teste com exemplo 3
        int[] nums3 = { 3, 3 };
        int target3 = 6;
        int[] result3 = solution.TwoSum(nums3, target3);
        Console.WriteLine($"Exemplo 3: [{result3[0]}, {result3[1]}]");

        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}