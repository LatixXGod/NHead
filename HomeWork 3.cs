using System;

namespace Homework1_3
{
    class Program
    {
        static int FibonachiFor(int n)
        {
            int f0 = 0;
            int f1 = 1;
            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                sum = f0 + f1;
                f0 = f1;
                f1 = sum;
            }
            return n switch
            {
                0 => 0,
                1 => 1,
                _ => sum
            };
            static void Main(string[] args)
            {
                for (int i = 0; i < 20; i++)
                {
                    Console.WriteLine(FibonachiFor(i));
                }
                Console.WriteLine();
                for (int i = 0; i < 20; i++)
                {
                    Console.WriteLine(FibonachiFor(i));
                }
            }
        }
        static int FibonachiRecurs(int n) 
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return FibonachiRecurs(n - 1) + FibonachiRecurs(n - 2);
        }
        
       
    }
}
