using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class LeftRotate
    {
        public static int[] RotLeft(int[] a, int d)
        {
            var finalArray = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                if (i >= d)
                {
                    var t = i - d;
                    finalArray[t] = a[i];
                }
                else
                {
                    var t = a.Length - d + i;
                    finalArray[t] = a[i];
                }
            }

            return finalArray;
        }

    }
}
