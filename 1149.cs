using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BaekjoonCs
{
    class _1149
    {
        private static StreamReader sr = new StreamReader(Console.OpenStandardInput());
        private static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

        private static int n;
        private static int[,] cost;
        private static int[,] save;

        private static void Search(int m)
        {
            if (m <= 0) return;
            for (int j = 0; j < 3; j++)
            {
                int min = 10000000;
                for (int k = 0; k < 3; k++)
                {
                    if (j == k) continue;

                    if (save[n - 1 - m, k] + cost[n - m, j] < min) 
                        min = save[n - 1 - m, k] + cost[n - m, j];
                }

                save[n - m, j] = min;
            }
            Search(m - 1);
        }

        public static void Solution()
        {
            n = int.Parse(sr.ReadLine());
            cost = new int[n, 3];
            save = new int[n, 3];

            for (int i = 0; i < n; i++)
            {
                int[] a = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                for (int j = 0; j < 3; j++)
                {
                    cost[i, j] = a[j];
                }
            }

            for (int j = 0; j < 3; j++)
                save[0, j] = cost[0, j];

            Search(n - 1);

            int answer = 10000000;
            for (int j = 0; j < 3; j++)
            {
                if (answer > save[n - 1, j]) answer = save[n - 1, j];
            }
            sw.WriteLine(answer);
            sw.Close();
            sr.Close();
        }
    }
}
