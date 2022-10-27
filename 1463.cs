using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BaekjoonCs
{
    class _1463
    {
        private static StreamReader sr = new StreamReader(Console.OpenStandardInput());
        private static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

        public static void Solution()
        {
            int n = int.Parse(sr.ReadLine());
            int[] save = new int[n + 1];
            save[0] = 0;
            save[1] = 0;

            for (int i = 2; i <= n; i++)
            {
                int min = n;
                if (i % 3 == 0 && min > save[i / 3]) min = save[i / 3];
                if (i % 2 == 0 && min > save[i / 2]) min = save[i / 2];
                if (min > save[i - 1]) min = save[i - 1];

                save[i] = min + 1;
            }

            sw.WriteLine(save[n]);

            sw.Close();
            sr.Close();
        }
    }
}
