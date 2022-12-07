using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BaekjoonCs
{
    class _2156
    {
        private static StreamReader sr = new StreamReader(Console.OpenStandardInput());
        private static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

        private static int n;
        private static int[] wine;
        private static int[,] save;
        /* save[i,j]
         * i: wine의 index
         * j: 연속해서 더 마실 수 있는 와인의 양
         */

        public static void Solution()
        {
            n = int.Parse(sr.ReadLine());
            wine = new int[n];
            save = new int[n, 3];

            for (int i = 0; i < n; i++)
            {
                wine[i] = int.Parse(sr.ReadLine());
            }

            save[0, 1] = wine[0];

            for (int i = 1; i < n; i++)
            {
                int amount = wine[i];
                // 마신다
                for (int j = 0; j <= 1; j++)
                {
                    save[i, j] = save[i - 1, j + 1] + wine[i];
                }
                // 안마신다
                // 이 전 상황에서 가장 큰 값을 가져옴
                save[i, 2] = Math.Max(save[i - 1, 2], save[i - 1, 1]);
                save[i, 2] = Math.Max(save[i - 1, 0], save[i, 2]);
            }

            int max = 0;
            for (int i = 0; i < 3; i++)
            {
                if (max < save[n - 1, i]) max = save[n - 1, i];
            }

            sw.WriteLine(max);
            sw.Close();
            sr.Close();
        }
    }
}
