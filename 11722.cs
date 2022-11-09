using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BaekjoonCs
{
    class _11722
    {
        private static StreamReader sr = new StreamReader(Console.OpenStandardInput());
        private static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

        public static void Solution()
        {
            int n = int.Parse(sr.ReadLine());

            int[] a = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

            int[] save = new int[n];
            int answer = 0;

            for (int i = 0; i < n; i++)
            {
                int max = 1;

                for (int j = 0; j < i; j++)
                {
                    if (a[i] < a[j] && max < save[j] + 1) max = save[j] + 1;
                }

                save[i] = max;
                if (answer < max) answer = max;
            }

            sw.WriteLine(answer);
            sw.Close();
            sr.Close();
        }
    }
}
