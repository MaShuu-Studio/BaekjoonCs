using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BaekjoonCs
{
    class _10971
    {
        private static StreamReader sr = new StreamReader(Console.OpenStandardInput());
        private static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

        private static int n;
        private static int[,] w;
        private static bool[] visited;
        private static int min;

        private static void Search(int start, int cur, int weight, int count)
        {
            if (count == n - 1)
            {
                if (w[cur, start] != 0)
                {
                    weight += w[cur, start];
                    if (min > weight) min = weight;
                }
                return;
            }

            visited[cur] = true;
            for (int i = 0; i < n; i++)
            {
                if (w[cur, i] == 0) continue;
                if (visited[i]) continue;
                Search(start, i, weight + w[cur, i], count + 1);

            }
            visited[cur] = false;
        }

        public static void Solution()
        {
            n = int.Parse(sr.ReadLine());
            w = new int[n, n];
            visited = new bool[n];
            min = 0;

            for (int i = 0; i < n; i++)
            {
                int[] wi = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                for (int j = 0; j < n; j++)
                {
                    w[i, j] = wi[j];
                }
                min += 1000001;
            }

            for (int i = 0; i < n; i++)
                Search(i, i, 0, 0);

            sw.WriteLine(min);
            sw.Close();
            sr.Close();
        }
    }
}
