using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.FindsIndexBinary
{
    class Program
    {
        static int BinSearch(int[] array, int key)
        {//searching in sorted array to find where is integer 7
            //the searching algorithm is from zero to max divide by two
            //checking if its to much or less than divide again till the number is founded 
            Array.Sort(array);
            int iMax = array.Length - 1;
            int iMin = 0;
            while (iMax >= iMin)
            {
                int iMidpoint = (iMin + iMax) / 2;
                if (array[iMidpoint] < key)
                {
                    iMin = iMidpoint + 1;
                }
                else if (array[iMidpoint] > key)
                {
                    iMax = iMidpoint - 1;
                }
                else
                {
                    return iMidpoint;
                }
            }
            return -1;
        }

        static void Main()
        {
            int[] myArray = { 4, 7, 4, 6, 2, 7, 5, 12, 22, 13, };
            int key = 7;
            Console.WriteLine(BinSearch(myArray, key));
        }
    }
}

