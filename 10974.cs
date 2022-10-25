using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BaekjoonCs
{
    class _10974
    {
        private static StreamReader sr = new StreamReader(Console.OpenStandardInput());
        private static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
        private static StringBuilder sb = new StringBuilder();

        private static int n;
        private static List<int> s = new List<int>();
        private static bool[] visited;

        private static void Search()
        {
            if(s.Count == n)
            {
                string str = "";
                for (int i = 0; i < n; i++)
                {
                    str += s[i] + " ";
                }
                sb.AppendLine(str);
                return;
            }

            for (int i = 1; i <= n; i++)
            {
                if (visited[i]) continue;
                visited[i] = true;
                s.Add(i);
                Search();
                s.Remove(i);
                visited[i] = false;
            }
        }

        public static void Solution()
        {
            n = int.Parse(sr.ReadLine());
            visited = new bool[n + 1];

            Search();

            sw.WriteLine(sb);

            sw.Close();
            sr.Close();
        }
    }
}
