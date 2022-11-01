using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BaekjoonCs
{
    class _10819
    {
        private static StreamReader sr = new StreamReader(Console.OpenStandardInput());
        private static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

        private static int n;
        private static int[] array;
        private static int[] cur;
        private static bool[] visited;
        private static int max;

        private static void Search(int count)
        {
            if (count == n)
            {
                int val = 0;
                for (int i = 1; i < n; i++)
                {
                    int a = array[cur[i - 1]];
                    int b = array[cur[i]];
                    val += Math.Abs(a - b);
                }
                if (val > max) max = val;
                return;
            }

            for (int i = 0; i < n; i++)
            {
                if (visited[i]) continue;
                cur[count] = i;
                visited[i] = true;
                Search(count + 1);
                visited[i] = false;
            }
        }

        public static void Solution()
        {
            n = int.Parse(sr.ReadLine());

            array = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            visited = new bool[n];
            cur = new int[n];
            max = 0;
            Search(0);

            sw.WriteLine(max);
            sw.Close();
            sr.Close();
        }
    }
}
