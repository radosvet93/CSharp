using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.task
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 2, 3, 4, 5, 2, 2, 4, 5, 6, 7 };

            int count = 1;
            int longestSequence = 0;
            string longestSequenceNum = "";
            string sequenceNum = "";

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] < arr[i + 1])
                {
                    count++;
                    sequenceNum += arr[i] + " ";
                }
                else
                {
                    if (longestSequence < count)
                    {
                        sequenceNum += arr[i] + " ";
                        longestSequence = count;
                        longestSequenceNum = sequenceNum;
                    }
                    count = 1;
                    sequenceNum = "";
                }
            }
            //for the last element
            if (longestSequence < count)
            {
                longestSequenceNum += arr[arr.Length - 1] + " ";
                longestSequence = count;
            }
            //write it on the console
            Console.WriteLine("The longest sequence is array of these numbers {0}", longestSequenceNum);

        }
    }
}

