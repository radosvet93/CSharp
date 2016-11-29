using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.PrintA_Z
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "hello";
            char[] alphabet = new char[26];
            for (int i = 0; i < 26; i++)
            {
                alphabet[i] = (char)(i + (int)('a'));

            }

        }
    }
}
