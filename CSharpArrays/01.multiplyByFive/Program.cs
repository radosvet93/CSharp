using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.task
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] multiplyByFive = new int[20];

            for (int i = 0; i < multiplyByFive.Length; i++)
            {
                multiplyByFive[i] = i;
            }
            foreach (var item in multiplyByFive)
            {
                Console.WriteLine(item * 5);
            }
        }
    }
}

