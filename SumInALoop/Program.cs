using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumInALoop
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Now our goal is to learn the loops - i.e. repeated actions. Let us find the sum of several numbers (more than two).
             *  It will be useful to do this in a loop. As shown in the picture above - you can create variable sum and add every value 
             *  from the list to it. Perhaps "for" loop will suit nicely since the amount of numbers is known beforehand.
             *
            *      If you have troubles, try Sums In Loop first - it is, probably, easier.
            *
             *       Input data has the following format:
             *
              *      first line contains N - amount of values to sum;
               *     second line contains N values themselves.
            */

            int sum = 0;

            Console.Write("The amount of value to sum : ");
            int amount = Convert.ToInt32(Console.ReadLine());

            
            int[] values = new int[amount];
            

            for (int i = 0; i <amount; i++)
            {
                Console.Write("Enter a number : ");
                values[i] = Convert.ToInt32(Console.ReadLine()); 
                
            }

            for (int i = 0; i < amount; i++)
            {
                sum += values[i] ;

            }
            Console.WriteLine(sum);







        }
    }
    }

