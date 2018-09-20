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

        public static void minimumBribes1(int[] q)
        {
            bool chaotic = false;
            int sum = 0;
            var temp1 = 0;
            for (int i = 0; i < q.Length; i++)
            {
                bool matched = true;
                for (int j = 0; j < q.Length - 1; j++)
                {
                    var k = q[j] - (j + 1);
                    if (k > 2)
                    {
                        chaotic = true;
                        break;
                    }

                    if (q[j] > q[j + 1])
                    {
                        temp1 = q[j];
                        q[j] = q[j + 1];
                        q[j + 1] = temp1;
                        sum++;
                    }


                    if (q[j] != j + 1)
                    {
                        matched = false;
                    }
                }

                if (matched)
                {
                    break;
                }

            }

            if (chaotic)
                Console.WriteLine("Too Chaotic");
            else
                Console.WriteLine(sum);

        }
    }
}
