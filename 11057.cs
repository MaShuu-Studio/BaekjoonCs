using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BaekjoonCs
{
    class _11057
    {
        private static StreamReader sr = new StreamReader(Console.OpenStandardInput());
        private static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

        private static int n;
        private static int[,] save;

        private static void Search(int m)
        {
            if (m <= 0) return;

            for (int i = 0; i < 10; i++)
            {
                for (int j = i; j >= 0; j--)
                {
                    save[n - m, i] += save[n - m - 1, j] % 10007;
                }
            }
            Search(m - 1);
        }

        public static void Solution()
        {
            n = int.Parse(sr.ReadLine());
            save = new int[n, 10]; // 0, 왼, 우

            for (int i = 0; i < 10; i++)
            {
                save[0, i] = 1;
            }

            Search(n - 1);

            int answer = 0;
            for (int i = 0; i < 10; i++)
            {
                answer += save[n - 1, i];
                answer %= 10007;
            }
            sw.WriteLine(answer);
            sw.Close();
            sr.Close();
        }
    }
}
