using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BaekjoonCs
{
    class _15988
    {
        private static StreamReader sr = new StreamReader(Console.OpenStandardInput());
        private static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

        public static void Solution()
        {
            int n = int.Parse(sr.ReadLine());
            long[] save = new long[1000001];
            save[0] = 0;
            save[1] = 1;
            save[2] = 2;
            save[3] = 4;

            for (int i = 4; i < 1000001; i++)
            {
                save[i] = (save[i - 1] + save[i - 2] + save[i - 3]) % 1000000009;
            }

            for (int i = 0; i < n; i++)
            {
                int m = int.Parse(sr.ReadLine());

                sw.WriteLine(save[m]);
            }

            sw.Close();
            sr.Close();
        }
    }
}
