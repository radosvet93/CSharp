using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.task
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 1, 2, 312, 41, 41, 41, 51, 23, 123, 5, };

            int counter = 1;
            int longestSequence = 0;
            int value = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    counter++;
                    if (longestSequence < counter)
                    {
                        longestSequence = counter;
                        value = arr[i];
                    }
                }
                else
                {
                    counter = 1;
                }
            }

            if (longestSequence < 2)
            {
                Console.WriteLine("There is no sequence longer than 1");
            }
            else
            {
                Console.WriteLine("Longest sequence is {0} from these integer {1}", longestSequence, value);
            }


        }
    }
}

