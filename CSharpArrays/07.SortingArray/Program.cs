using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.task
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 6, 3, 2, 7, 1, 10 };
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
            foreach (var sortArray in arr)
            {
                Console.WriteLine(sortArray);
            }



        }
    }
}
