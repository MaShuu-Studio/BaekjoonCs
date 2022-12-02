using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BaekjoonCs
{
    class _11052
    {
        private static StreamReader sr = new StreamReader(Console.OpenStandardInput());
        private static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

        private static int n;
        private static int[] p;
        private static int[] save;

        public static void Solution()
        {
            int n = int.Parse(sr.ReadLine());
            p = new int[n + 1];
            Array.ConvertAll(sr.ReadLine().Split(), int.Parse).CopyTo(p, 1);
            save = new int[n + 1];

            save[1] = p[1];
            for (int i = 2; i <= n; i++) // 몇 장 살지
            {
                int max = p[i];
                int maxPos = i;
                for (int j = i - 1; j >= 1; j--) // 어떻게 사는게 좋을지
                {
                    if (save[j] + save[i-j] > max)
                    {
                        max = save[j] + save[i - j];
                        maxPos = j;
                    }
                }
                save[i] = max;
            }

            sw.WriteLine(save[n]);
            sw.Close();
            sr.Close();
        }
    }
}
