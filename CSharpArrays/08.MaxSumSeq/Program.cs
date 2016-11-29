using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.task
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };

            int currentSum = 0;
            int startIndex = 0;
            int endIndex = 0;
            int tempStartIndex = 0;
            int maxSum = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (currentSum > 0)
                {
                    currentSum += arr[i];
                }
                else
                {
                    currentSum = arr[i];
                    tempStartIndex = i;
                }

                if (currentSum > maxSum) 
                {
                    maxSum = currentSum;
                    startIndex = tempStartIndex;
                    endIndex = i;
                }
            }
            for (int i = startIndex; i <= endIndex; i++)
            {
                Console.WriteLine("The best sequence is {0} in position {1}", arr[i], i);
            }

            Console.WriteLine("The max sum is " + maxSum);


        }
    }
}
