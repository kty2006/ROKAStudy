using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {   
        int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        Dictionary<int,(int,int)> prices = new Dictionary<int, (int, int)>();
        int all = input[1];
        int maxP = 0;
        for(int i = 0; i < input[0]; i++)
        {
            int[] input_ = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            prices.Add(i,(input_[0],input_[1]));
        }
        
        int maxWSum = prices.Values.Sum(x => x.Item1);
        int maxPSum = prices.Values.Sum(x => x.Item2);
        bool[] w = new bool[maxWSum + 1];
        bool[] p = new bool[maxPSum + 1];
        bool[] dp = new bool[1 << prices.Count];
        dp[0] = true;

        foreach(var price in prices.Values)
        {
            for(int sum = maxPSum; sum >= price.Item2; sum--)
            {

                if (dp[sum - price.Item2])
                {
                  dp[sum] = true;
                  int weight = prices.Values.Where(x => x.Item2 == sum).Select(x => x.Item1).FirstOrDefault();
                  if(sum > maxP && price())
                }
                // dp[sum] = dp[sum] || dp[sum - price.Item2];
                
            }
        }

    }
}