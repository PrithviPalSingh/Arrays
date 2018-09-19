using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class NewYearChaos
    {
        public static void minimumBribes(int[] q)
        {
            int temp = 0;
            int temp2 = 0;
            int ctr = 0;
            bool chaotic = false;
            foreach (int i in q)
            {
                bool matched = true;
                for (int x = 0; x < q.Length - 1; x++)
                {
                    if (q[x] - (x + 1) > 2)
                    {
                        chaotic = true;
                        break;
                    }
                    if (q[x] > q[x + 1])
                    {
                        temp = q[x + 1];
                        temp2 = q[x];
                        q.SetValue(temp2, x + 1);
                        q.SetValue(temp, x);
                        ctr++;
                    }

                    if (q[x] != x + 1)
                    {
                        matched = false;
                    }
                }
                if (matched) { break; }
            }
            if (chaotic)
            {
                Console.WriteLine("Too chaotic");
            }
            else
            {
                Console.WriteLine(ctr);
            }
        }
    }
}
