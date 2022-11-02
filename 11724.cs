using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BaekjoonCs
{
    class _11724
    {
        private static StreamReader sr = new StreamReader(Console.OpenStandardInput());
        private static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

        private static int n, m;
        private static List<int>[] list;
        private static int answer;
        private static int[] linked;
        private static bool[] visited;

        private static void Search(int pos)
        {
            visited[pos] = true;
            linked[pos] = answer;
            for (int i = 0; i < list[pos].Count; i++)
            {
                int dest = list[pos][i];
                if (visited[dest]) continue;
                Search(dest);
            }
        }

        public static void Solution()
        {
            int[] nm = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

            n = nm[0];
            m = nm[1];

            list = new List<int>[n + 1];
            linked = new int[n + 1];
            visited = new bool[n + 1];
            answer = 0;

            for (int i = 1; i <= n; i++)
                list[i] = new List<int>();

            for (int i = 0; i < m; i++)
            {
                int[] uv = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

                int u = uv[0];
                int v = uv[1];

                list[u].Add(v);
                list[v].Add(u);
            }
            for (int i = 1; i <= n; i++)
            {
                if (visited[i]) continue;
                if (linked[i] != 0) continue;
                answer++;
                Search(i);
            }

            sw.WriteLine(answer);
            sw.Close();
            sr.Close();
        }
    }
}
