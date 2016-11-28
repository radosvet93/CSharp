using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.task
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr1 = { 'a', 'e', 'd', 'o', 's' };
            char[] arr2 = { 'a', 'e', 'd', 'o', 's' };

            if (arr1.Length == arr2.Length)//same lengths
            {
                int sum1 = 0;
                int sum2 = 0;
                for (int i = 0; i < arr1.Length; i++)
                {
                    sum1 += arr1[i];
                    sum2 += arr2[i];
                }
                if (sum1 == sum2)
                {
                    Console.WriteLine("Two arrays are lexicograpical equal");
                }
                else
                {
                    if (sum1 > sum2)
                    {
                        Console.WriteLine("First is bigger");
                    }
                    else
                    {
                        Console.WriteLine("Second is bigger");
                    }
                }
            }
            else//different lengths
            {
                if (arr1.Length > arr2.Length)
                {
                    Console.WriteLine("First is bigger");
                }
                else
                {
                    Console.WriteLine("Second is bigger");
                }
            }
        }
    }
}
