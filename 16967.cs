using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BaekjoonCs
{
    class _16967
    {
        private static StreamReader sr = new StreamReader(Console.OpenStandardInput());
        private static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

        private static int h, w, x, y;
        private static int[,] a;
        private static int[,] b;

        public static void Solution()
        {
            int[] hwxy = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

            h = hwxy[0];
            w = hwxy[1];
            x = hwxy[2];
            y = hwxy[3];

            a = new int[h, w];
            b = new int[h + x, w + y];

            for (int i = 0; i < h+x; i++)
            {
                int[] bij = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

                for (int j = 0; j < w+y; j++)
                {
                    b[i, j] = bij[j];
                }
            }

            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    a[i, j] = b[i, j];
                }
            }

            for (int i = x; i < h; i++)
            {
                for(int j = y; j < w; j++)
                {
                    a[i, j] -= a[i - x, j - y];
                }
            }

            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    sw.Write(a[i, j] + " ");
                }
                sw.WriteLine();
            }

            sw.Close();
            sr.Close();
        }
    }
}
