using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumOfThree
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num1 = new int[] { 1, 4, 5, 7, 9 };
            int[] num2 = new int[] { 2, 3, 6, 8, 10 };
            int[] num3 = new int[] { 5, 6, 7, 1, 2 };
            int[] num4 = new int[num3.Length];

            for (int i = 0; i < num3.Length; i++)
            {
                if (num1[i] > num2[i] && num1[i] > num3[i])
                {
                    num4[i] = num1[i];
                }
              else  if (num2[i] > num1[i] && num2[i] > num3[i])
                {
                    num4[i] = num2[i];
                }
                else if (num3[i] > num1[i] && num3[i] > num2[i])
                {
                    num4[i] = num3[i];
                }
            }

            foreach (int s in num4)
            {
                Console.WriteLine(s);
            }
        }
    }
}
