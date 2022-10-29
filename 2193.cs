using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BaekjoonCs
{
    class _2193
    {
        private static StreamReader sr = new StreamReader(Console.OpenStandardInput());
        private static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

        public static void Solution()
        {
            int n = int.Parse(sr.ReadLine());

            long[] save = new long[n+1];

            for (int i = 1; i <= n; i++)
            {
                save[i] = 1; // 0만 붙이는 경우

                for (int j = i - 2; j>= 0; j--)
                {
                    save[i] += save[j];
                }
            }

            sw.WriteLine(save[n]);

            sw.Close();
            sr.Close();

        }
    }
}
