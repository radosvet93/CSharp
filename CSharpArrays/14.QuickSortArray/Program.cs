using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.QuickSortArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 1, 9, 4, 6, 7, 3, 5, 8, 10 };
            QuickSortAlg(arr, 0, 9);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
        static void QuickSortAlg(int[] arr, int left, int right)
        {
            int originalLeft = left;
            int originalRight = right;
            int pivot = arr[(left + right) / 2];

            while (left < right)
            {
                while (pivot > arr[left])
                {
                    left++;
                }
                while (pivot < arr[right])
                {
                    right--;
                }
                if (left <= right)
                {
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;

                    left++;
                    right--;
                }
            }
            if (originalLeft < right)
            {
                QuickSortAlg(arr, originalLeft, right);
            }
            if (left < originalRight)
            {
                QuickSortAlg(arr, left, originalRight);
            }
        }
    }
}
