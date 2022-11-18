using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BaekjoonCs
{
    class _18290
    {
        private static StreamReader sr = new StreamReader(Console.OpenStandardInput());
        private static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

        private static int n, m, k;
        private static int[,] a;
        private static bool[,] visited;
        private static int answer;
        private static int c;

        private static void Search(int count, int val)
        {
            if (count == k)
            {
                if (answer < val) answer = val;
                return;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (Visitable(i, j))
                    {
                        visited[i, j] = true;
                        Search(count + 1, val + a[i, j]);
                        visited[i, j] = false;
                    }
                }
            }
        }

        private static bool Visitable(int i, int j)
        {
            if (visited[i, j]) return false;
            if ((i > 0) && visited[i - 1, j]) return false;
            if ((i < n - 1) && visited[i + 1, j]) return false;
            if ((j > 0) && visited[i, j - 1]) return false;
            if ((j < m - 1) && visited[i, j + 1]) return false;

            return true;
        }
        public static void Solution()
        {
            int[] nmk = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            n = nmk[0];
            m = nmk[1];
            k = nmk[2];

            a = new int[n, m];
            visited = new bool[n, m];
            answer = -99999;

            for (int i = 0; i < n; i++)
            {
                int[] line = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = line[j];
                }
            }

            Search(0, 0);
            sw.WriteLine(answer);
            sw.Close();
            sr.Close();
        }
    }
}
