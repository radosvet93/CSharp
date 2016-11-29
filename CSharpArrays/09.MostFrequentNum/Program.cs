using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.MostFrequentNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4,4,4,4, 1, 1,1, 1, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3, 3, 3, 3, 3 };
            int bestNum = 0;
            int count = 1;
            int maxCount = 1;
            //sorting the array
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;

                    }
                }
            }


            //when the array is sorted we can easily do whatever we want
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] == arr[i])
                {
                    count++;
                    if (count > maxCount)
                    {
                        maxCount = count;
                        bestNum = arr[i];
                    }
                }
                else
                {
                    count = 1;
                }

            }
            Console.WriteLine("The best num is {0} repeating {1}", bestNum, maxCount);
        }
    }
}
