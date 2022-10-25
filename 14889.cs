using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BaekjoonCs
{
    class _14889
    {
        private static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
        private static StreamReader sr = new StreamReader(Console.OpenStandardInput());
        private static int n;
        private static int[,] s;
        private static int[] start;
        private static int answer;

        private static void Search(int member, int count)
        {
            if (count == n/2)
            {
                int dif = GetDif();
                if (answer > dif)
                    answer = dif;

                return;
            }

            for (int i = member; i < n; i++)
            {
                start[count] = i;
                Search(i + 1, count + 1);
                start[count] = 0;
            }
        }

        private static int GetDif()
        {
            int[] link = new int[n / 2];
            int linkmem = 0;

            for (int i = 0; i < n; i++)
            {
                bool isStart = false;
                for (int j = 0; j < start.Length; j++)
                {
                    isStart = i == start[j];
                    if (isStart) break;
                }
                
                if (isStart == false)
                {
                    link[linkmem] = i;
                    linkmem++;
                }
            }

            return Math.Abs(Power(start) - Power(link));
        }

        private static int Power(int[] team)
        {
            int pow = 0;
            for (int i = 0; i < team.Length; i++)
            {
                for (int j = i; j < team.Length; j++)
                {
                    pow += s[team[i], team[j]];
                    pow += s[team[j], team[i]];
                }
            }

            return pow;
        }

        public static void Solution()
        {
            n = int.Parse(sr.ReadLine());
            s = new int[n, n];
            start = new int[n / 2];
            answer = 0;

            for (int i = 0; i < n; i++)
            {
                int[] tmp = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                for (int j = 0; j < tmp.Length; j++)
                {
                    s[i, j] = tmp[j];
                    answer += tmp[j];
                }
            }

            Search(0, 0);
            sw.WriteLine(answer);

            sw.Close();
            sr.Close();
        }
    }
}
