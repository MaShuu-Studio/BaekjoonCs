using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BaekjoonCs
{
    class _15661
    {
        private static StreamReader sr = new StreamReader(Console.OpenStandardInput());
        private static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

        private static int n;
        private static int answer;
        private static int[,] s;
        private static bool[] team;

        private static void Search(int num, int count)
        {
            for (; num < n; num++)
            {
                if (answer == 0) return;
                if (count < n - 1)
                {
                    team[num] = true;
                    Search(num + 1, count + 1);
                    team[num] = false;
                }
            }
            if (num == n)
            {
                int diff = Diff();
                if (answer > diff) answer = diff;

                return;
            }
        }

        private static int Diff()
        {
            List<int> start = new List<int>();
            List<int> link = new List<int>();

            for (int i = 0; i < n; i++)
            {
                if (team[i]) start.Add(i);
                else link.Add(i);
            }

            int sp = 0, lp = 0;
            for (int i = 0; i < start.Count; i++)
            {
                for (int j = i; j < start.Count; j++)
                {
                    sp += s[start[i], start[j]];
                    sp += s[start[j], start[i]];
                }
            }

            for (int i = 0; i < link.Count; i++)
            {
                for (int j = i; j < link.Count; j++)
                {
                    lp += s[link[i], link[j]];
                    lp += s[link[j], link[i]];
                }
            }

            return Math.Abs(sp - lp);
        }

        public static void Solution()
        {
            n = int.Parse(sr.ReadLine());
            s = new int[n, n];
            team = new bool[n];

            answer = 1000000;

            for (int i = 0; i < n; i++)
            {
                int[] line = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

                for (int j = 0; j < n; j++)
                {
                    s[i, j] = line[j];
                }
            }
            team[0] = true;
            int diff = Diff();
            if (answer > diff) answer = diff;

            Search(1, 1);
            sw.WriteLine(answer);
            sw.Close();
            sr.Close();
        }
    }
}
