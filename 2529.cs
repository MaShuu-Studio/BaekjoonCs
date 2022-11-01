using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BaekjoonCs
{
    class _2529
    {
        private static StreamReader sr = new StreamReader(Console.OpenStandardInput());
        private static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
        private static int k;
        private static bool[] rightIsBig;
        private static bool[] visited = new bool[10];
        private static int[] cur;
        private static long min, max;
        private static string mins, maxs;
        private static void Search(int count)
        {
            if (count == k + 1)
            {
                string s = "";
                long val = 0;
                for (int i = 0; i <= k; i++)
                {
                    val += cur[i] * (long)Math.Pow(10, k - i);
                    s += cur[i].ToString();
                }

                if (max < val)
                {
                    max = val;
                    maxs = s;
                }
                if (min > val)
                {
                    min = val;
                    mins = s;
                }

                return;
            }

            for (int i = 0; i <= 9; i++)
            {
                if (visited[i]) continue;
                if (count > 0)
                {
                    if ((rightIsBig[count - 1] && !(cur[count - 1] < i)) ||
                        (rightIsBig[count - 1] == false && !(cur[count - 1] > i))) 
                        continue;
                }
                visited[i] = true;
                cur[count] = i;
                Search(count + 1);
                visited[i] = false;
            }
        }

        public static void Solution()
        {
            k = int.Parse(sr.ReadLine());

            string[] list = sr.ReadLine().Split();
            rightIsBig = new bool[k];
            cur = new int[k + 1];

            for (int i = 0; i < k; i++)
            {
                rightIsBig[i] = list[i] == "<";
            }

            min = 9999999999;
            max = 0;

            Search(0);

            sw.WriteLine(maxs);
            sw.WriteLine(mins);
            sw.Close();
            sr.Close();
        }
    }
}
