using System;
using System.Linq;

class Program
{
    static void Main()
    {   
        int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        int n = input[0];
        int a = input[1];
        int b = input[2];
        int count = b - 2;
        
        if(count >= n)  
        {
          int loofCount  =  (count % n) == 0 ? 1 : count / n;

          Console.Write(loofCount);
        }
        else
        {
            Console.Write(count);
        }

    }
}