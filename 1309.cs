using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BaekjoonCs
{
    class _1309
    {
        private static StreamReader sr = new StreamReader(Console.OpenStandardInput());
        private static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

        private static int n;
        private static int[,] save;
        
        private static void Search(int m)
        {
            if (m <= 0) return;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i != 0 && i == j) continue;

                    save[n - m, i] += save[n - m - 1, j];
                }
                save[n - m, i] %= 9901;
            }
            Search(m - 1);
        }

        public static void Solution()
        {
            n = int.Parse(sr.ReadLine());
            save = new int[n, 3]; // 0, 왼, 우

            for (int i = 0; i < 3; i++)
            {
                save[0, i] = 1;
            }

            Search(n - 1);
            sw.WriteLine((save[n-1, 0] + save[n-1, 1] + save[n-1, 2]) % 9901);
            sw.Close();
            sr.Close();
        }
    }
}
