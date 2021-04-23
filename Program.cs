using System;

namespace HomeWork_2__2_2
{
    class Program
    {
        
        
           public static int BinarySearch(int[] inputArray, int searchValue)
            {
                int min = 0; // (1)
                int max = inputArray.Length - 1;//(1)
                while (min <= max)                                                       //O(N)
                {
                    int mid = (min + max) / 2;//(1)
                    if (searchValue == inputArray[mid])                                  
                    {
                        return mid;               //(1)
                    }
                    else if (searchValue < inputArray[mid])
                    {
                        max = mid - 1;
                    }
                    else
                    {
                        min = mid + 1;
                    }
                }
                return -1;          //(1)
            }


        // Асимптотическая сложность функции = O(N)
    }
}
