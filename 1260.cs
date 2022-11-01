using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BaekjoonCs
{
    class _1260
    {
        private static StreamReader sr = new StreamReader(Console.OpenStandardInput());
        private static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

        private static int n, m, v;
        private static bool[,] array;

        private static List<int> cur = new List<int>();
        private static bool[] visited;

        private static void DFS(int pos)
        {
            for (int i = 1; i <= n; i++)
            {
                if (visited[i]) continue;
                if (array[pos, i] == false) continue;

                visited[i] = true;
                cur.Add(i);
                DFS(i);
            }
        }

        private static void BFS()
        {
            int layer = 0;
            while (cur.Count > layer) 
            {
                int pos = cur[layer];
                for (int i = 1; i<= n; i++)
                {
                    if (visited[i]) continue;
                    if (array[pos, i] == false) continue;
                    visited[i] = true;
                    cur.Add(i);
                }

                layer++;
            }
        }

        private static void Init()
        {
            cur.Clear();
            for (int i = 0; i < visited.Length; i++)
            {
                visited[i] = false;
            }

            cur.Add(v);
            visited[v] = true;
        }

        private static void Result()
        {
            for (int i = 0; i < cur.Count; i++)
            {
                sw.Write(cur[i] + " ");
            }
            sw.WriteLine();
        }

        public static void Solution()
        {
            int[] nmv = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

            n = nmv[0];
            m = nmv[1];
            v = nmv[2];
            array = new bool[n + 1, n + 1];
            visited = new bool[n + 1];

            for (int i = 0; i < m; i++)
            {
                int[] line = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

                int a = line[0];
                int b = line[1];

                array[a, b] = true;
                array[b, a] = true;
            }

            Init();
            DFS(v);
            Result();

            Init();
            BFS();
            Result();

            sw.Close();
            sr.Close();
        }
    }
}
