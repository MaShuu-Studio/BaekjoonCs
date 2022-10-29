using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BaekjoonCs
{
    class _15990
    {
        private static StreamReader sr = new StreamReader(Console.OpenStandardInput());
        private static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

        public static void Solution()
        {
            long[,] save = new long[100001, 4];
            int index;

            save[1, 1] = 1;
            save[1, 2] = 0;
            save[1, 3] = 0;

            save[2, 1] = 0;
            save[2, 2] = 1;
            save[2, 3] = 0;

            save[3, 1] = 1;
            save[3, 2] = 1;
            save[3, 3] = 1;

            for (index = 4; index <= 100000; index++)
            {
                save[index, 1] = (save[index - 1, 2] + save[index - 1, 3]) % 1000000009;
                save[index, 2] = (save[index - 2, 1] + save[index - 2, 3]) % 1000000009;
                save[index, 3] = (save[index - 3, 1] + save[index - 3, 2]) % 1000000009;
            }

            int t = int.Parse(sr.ReadLine());

            for (int i = 0; i < t; i++)
            {
                int n = int.Parse(sr.ReadLine());

                sw.WriteLine((save[n, 1] + save[n, 2] + save[n, 3]) % 1000000009);
            }
            sw.Close();
            sr.Close();
        }
    }
}
