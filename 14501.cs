using System;
using System.Collections.Generic;
using System.Text;

namespace BaekjoonCs
{
    class _14501
    {
        private static int max;
        private static int[,] pay;
        private static int n;
        private static void DFS(int day, int consult, int p)
        {
            if (consult > 0)
            {
                DFS(day + 1, consult - 1, p);
                return;
            }

            if (max < p) max = p;

            if (day >= n) return;

            for (int i = day; i < n; i++)
            {
                if (pay[i, 0] > n - i)
                    continue;

                DFS(i + 1, pay[i, 0] - 1, p + pay[i, 1]);
            }
        }
        public static void Solution()
        {
            n = int.Parse(Console.ReadLine());
            pay = new int[n, 2];
            max = 0;

            for (int i = 0; i < n; i++)
            {
                int[] func = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                pay[i, 0] = func[0];
                pay[i, 1] = func[1];
            }

            DFS(0, 0, 0);

            Console.WriteLine(max);
        }
    }
}
