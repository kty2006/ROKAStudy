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
        int count = 1;
        int gcd;
         
        if(b > a)
        {
            (a,b) = (b,a);
        }

        gcd = GCD(a,b);

        count =  (a/gcd) -2;
        
        if(count >= n)  
        {
          int loofCount  =  (count % n) == 0 ? n : count % n;

          Console.Write(loofCount);
        }
        else
        
        {
            Console.Write(count);
        }

    }

    public static int GCD(int a, int b)
    {
        int remain = 1;
        while(remain != 0)
        {
            remain = a % b;
            a = b;
            b = remain;
        }
        // Console.WriteLine("GCD: {0}", a);
        return a;
    }
}