using System;
using System.Linq;

class Program
{
    static void Main()
    {   
        int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        Dictionary<int,int> prices = new Dictionary<int, int>();
        int all = input[1];
        int lastParice;
        int lastW;
        for(int i = 0; i < input[0]; i++)
        {
            int[] input_ = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            prices.Add(input_[0],input_[1]);
        }
        
        while(true)
        {
            int i = 0;
            int w = 0;
            lastW = 0;
            
            lastParice = prices[i] + prices[i+1];
            for(int o = 0; o <= 1; o++)
            {
                lastW += prices.FirstOrDefault(x => x.Value == prices[i+o]).Key;
            }
        }

    }
}