using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.FindsSeqOfGivenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 3, 1, 4, 2, 5, 8, 10 };
            //Example:	 {4, 3, 1, 4, 2, 5, 8, 10}, S=25  {2, 5, 8, 10}	
            int s = 25;

            int currentSum = 0;
            int start = 0;
            int end = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                currentSum += arr[i];
                start = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    currentSum += arr[j];
                    end = j;
                    if (currentSum == s)
                    {
                        for (int k = start; k <= end; k++)
                        {
                            Console.WriteLine(arr[k]);
                        }
                        return;
                    }
                    if (currentSum > s)
                    {
                        break;
                    }
                }
                currentSum = 0;
            }
            Console.WriteLine("There is no sum for number S");
        }
    }
}
