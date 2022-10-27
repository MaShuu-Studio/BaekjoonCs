using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BaekjoonCs
{
    class _11727
    {
        private static StreamReader sr = new StreamReader(Console.OpenStandardInput());
        private static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

        public static void Solution()
        {
            int n = int.Parse(sr.ReadLine());
            int[] save = new int[n + 2];

            save[0] = 0;
            save[1] = 1;
            save[2] = 3;

            for (int i = 3; i <= n; i++)
            {
                save[i] = (save[i - 1] + save[i - 2] * 2) % 10007;
            }

            sw.WriteLine(save[n]);

            sw.Close();
            sr.Close();
        }
    }
}
