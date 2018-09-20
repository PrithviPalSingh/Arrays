using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class MinimumSwaps
    {
        public static int minimumSwaps2(int[] arr)
        {
            var swapCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                var minIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                if (arr[minIndex] != arr[i])
                {
                    var temp = arr[i];
                    arr[i] = arr[minIndex];
                    arr[minIndex] = temp;
                    swapCount++;
                }
            }

            return swapCount;
        }

        public static int minimumSwaps(int[] arr)
        {
            int i, c = 0, n = arr.Length;

            for (i = 0; i < n; i++)
            {

                var k = arr[i] > arr.Length ? arr.Length : arr[i];
                if (k == (i + 1))
                    continue;

                var j = arr[i] > arr.Length - 1 ? arr.Length - 1 : arr[i] - 1;
                Exchange(arr, i, j);
                c++;
                i--;
            }

            return c;
        }

        public static int minimumSwaps1(int[] arr)
        {
            var swapCount = 0;
            Sort(arr, 0, arr.Length - 1, ref swapCount);
            return swapCount;
        }

        private static void Sort(int[] arr, int low, int high, ref int swapCount)
        {
            if (low >= high)
                return;

            int j = Partition(arr, low, high, ref swapCount);
            Sort(arr, low, j - 1, ref swapCount);
            Sort(arr, j + 1, high, ref swapCount);
        }

        private static int Partition(int[] items, int low, int high, ref int swapCount)
        {
            int N = items.Length;
            int i = low;
            int j = high + 1;
            while (true)
            {
                while (Less(items[++i], items[low]))
                {
                    if (i == high)
                        break;
                }

                while (Less(items[low], items[--j]))
                {
                    if (j == low)
                        break;
                }

                if (i >= j)
                    break;

                Exchange(items, i, j);
            }

            Exchange(items, low, j);
            swapCount++;

            return j;
        }

        public static void Exchange(int[] arr, int minIndex, int indextoSwap)
        {
            var swap = arr[minIndex];
            arr[minIndex] = arr[indextoSwap];
            arr[indextoSwap] = swap;
        }

        public static bool Less(int a, int b)
        {
            return a.CompareTo(b) < 0;
        }
    }
}
