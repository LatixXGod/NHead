using System;

namespace Homework_2_1_2
{
    class Program
    {
        public static int StrangeSum(int[] inputArray)
        {
            int sum = 0;
            for (int i = 0; i < inputArray.Length; i++) //0(N)
            {
                for (int j = 0; j < inputArray.Length; j++)// 0(N^2)
                {
                    for (int k = 0; k < inputArray.Length; k++)// 0(N^3)
                    {
                        int y = 0;

                        if (j != 0)
                        {
                            y = k / j;
                        }

                        sum += inputArray[i] + i + k + j + y;
                    }
                }
            }

            return sum;
        }
    }
}
