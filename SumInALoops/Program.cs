using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumInALoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] first = { 1, 3, 5, 7, 9, 2, 4, 6};
            int[] second = { 1, 3, 5, 7, 9, 2, 4, 6 };
            int[] third = new int[first.Length]; 

            for (int i = 0; i < first.Length; i++)
            {
                third[i] = first[i] + second[i];
                
            }
            foreach (int s in third)
            {
                Console.WriteLine(s);
            }
            for (int i = 0; i < third.Length; i++)
            {
                sum += third[i];
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
