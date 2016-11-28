using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter N");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter array elements {0}", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter K");
            Console.WriteLine();
            int k = int.Parse(Console.ReadLine());

            string bestSeq = "";
            int sum = 0;
            int bestSum = int.MinValue;
            int arrayLen = arr.Length;

            for (int i = 0; i < arrayLen; i++)
            {
                string currentSeq = "";

                if (i + k > arrayLen)
                {
                    break;
                }

                for (int j = 0; j < i + k; j++)
                {
                    sum = sum + arr[j];
                    currentSeq = currentSeq + ' ' + arr[j];
                }

                if (sum > bestSum)
                {
                    bestSeq = currentSeq;
                    bestSum = sum;

                }
                sum = 0;
            }
            Console.WriteLine(bestSeq + "\n" + bestSum);

        }
    }
}
