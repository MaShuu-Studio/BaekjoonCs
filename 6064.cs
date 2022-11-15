using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BaekjoonCs
{
    class _6064
    {
        private static StreamReader sr = new StreamReader(Console.OpenStandardInput());
        private static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

        private static int Kaing(int m, int n, int x, int y)
        {
            int year = x - 1;
            int max = LCM(m, n);

            x = 1;
            y -= year;
            while (y < 1) y += n;

            year += 1;
            while (y != 1)
            {
                y -= m;
                year += m;
                while (y < 1) y += n;
                if (year > max)
                {
                    year = -1;
                    break;
                }
            }
            return year;
        }

        private static int GCD(int a, int b)
        {
            if (a < b)
            {
                int tmp = a;
                a = b;
                b = tmp;
            }

            do
            {
                int remain = a % b;
                a = b;
                b = remain;
            }
            while (b > 0);

            return a;
        }

        private static int LCM(int a, int b)
        {
            return a * b / GCD(a, b);
        }

        public static void Solution()
        {
            int t = int.Parse(sr.ReadLine());

            for (int i = 0; i < t; i++)
            {
                int[] mnxy = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                int m, n, x, y;
                m = mnxy[0];
                n = mnxy[1];
                x = mnxy[2];
                y = mnxy[3];

                sw.WriteLine(Kaing(m, n, x, y));
            }
            sw.Close();
            sr.Close();
        }
    }
}
    