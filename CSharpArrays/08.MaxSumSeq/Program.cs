using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.task
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };

            //int currentSum = 0;
            //int startIndex = 0;
            //int endIndex = 0;
            //int tempStartIndex = 0;
            //int maxSum = arr[0];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (currentSum < 0 )
            //    {
            //        currentSum = arr[i];
            //        tempStartIndex = i;
            //    }
            //    else
            //    {
            //        currentSum += arr[i];
            //    }
            //    if (currentSum > maxSum)
            //    {
            //        maxSum = currentSum;

            //        startIndex = tempStartIndex;
            //        endIndex = i;
            //    }
            //}
            //Console.WriteLine("The best sum is: {0} ",maxSum);
            //Console.WriteLine("The best sequence is :");
            //for (int i = startIndex ; i <= endIndex; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}


            //{ 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 }
            int currentSum = 0;//vremenna suma na cislata
            int startIndex = 0;//indeksa na chisloto ot koeto zapochva poredicata
            int endIndex = 0;//indeksa na chisloto na koeto zavur6va poredicata
            int tempStartIndex = 0;//indeksa na momentnoto chisloo koeto proverqvame
            int maxSum = arr[0];//nai golqmata suma namerena

            for (int i = 0; i < arr.Length; i++)
            {
                if (currentSum > 0)//ako tekushtata suma e po golqma ot 0
                {
                    currentSum += arr[i];//zapisvame tekushtiq element v sumata
                }
                else
                {
                    currentSum = arr[i];//ako ne tekush6tata suma stava tekush6tiq element
                    tempStartIndex = i;// vremenata startova poziciq e poziciqta na elementa
                }

                if (currentSum > maxSum)//tekushtata suma ako e po golqma ot nai golqmata 
                {
                    maxSum = currentSum;// zapizvame tekushtata suma
                    startIndex = tempStartIndex;// startoviq index e raven na vremenniq
                    endIndex = i;// posledniq index i tekushtiq
                }
            }
            for (int i = startIndex; i <= endIndex; i++)//otpechatvame na konzolata ot purviq sre6tnat v poredicata do posledniq takuv
            {
                Console.WriteLine("The best sequence is {0} in position {1}", arr[i], i);
            }

            Console.WriteLine("The max sum is " + maxSum);


        }
    }
}
