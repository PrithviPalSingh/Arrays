using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //var a = LeftRotate.RotLeft(new int[] { 1, 2, 3, 4, 5 }, 4);
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine(a[i]);
            //}

            //NewYearChaos.minimumBribes(new int[] { 1, 2, 5, 3, 7, 8, 6, 4 });
            //NewYearChaos.minimumBribes1(new int[] { 1, 2, 5, 3, 7, 8, 6, 4 });

            Console.WriteLine(MinimumSwaps.minimumSwaps(new int[] { 7, 1, 3, 2, 4, 5, 6 }));

            Console.Read();
        }
    }
}
