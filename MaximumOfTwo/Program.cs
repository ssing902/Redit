using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumOfTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num1 = new int[] { 1, 4, 5, 7, 9 };
            int[] num2 = new int[] { 2, 3, 6, 8, 10 };
            int[] num3 = new int[num1.Length];

            for (int i = 0; i < num1.Length; i++)
            {
                if (num1[i] > num2[i])
                {
                    num3[i] = num1[i];
                }
                else
                if (num2[i] > num1[i])
                {
                    num3[i] = num2[i];
                }
            }
            foreach (int s in num3)
            {
                Console.WriteLine(s);
            }           
        }
    }
}
