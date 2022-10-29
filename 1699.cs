using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BaekjoonCs
{
    class _1699
    {
        private static StreamReader sr = new StreamReader(Console.OpenStandardInput());
        private static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

        public static void Solution()
        {
            int n = int.Parse(sr.ReadLine());

            int[] save = new int[n + 1];

            save[0] = 0;
            save[1] = 1;
            for (int i = 2; i <= n; i++)
            {
                int min = save[i - 1] + 1;
                int rt = (int)Math.Sqrt(i);
                for (int j = 2; j <= rt; j++)
                {
                    int val = save[i - j * j] + 1;
                    if (val < min) min = val; 
                }

                save[i] = min;
            }

            sw.WriteLine(save[n]);
            sw.Close();
            sr.Close();
        }
    }
}
