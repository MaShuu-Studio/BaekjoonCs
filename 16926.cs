using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BaekjoonCs
{
    class _16926
    {
        private static StreamReader sr = new StreamReader(Console.OpenStandardInput());
        private static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

        private static int n, m, r;
        private static int[,] a;
        private static int layer;

        private static void Turn(int l)
        {
            int turn = ((n - 2 * l) + (m - 2 * l)) * 2 - 4;
            int round = r % turn;

            while (round > 0)
            {
                // 위쪽 라인
                for (int j = l; j < m - l - 1; j++)
                {
                    Swap(ref a[l, j], ref a[l, j + 1]);
                }

                // 오른쪽 라인
                for (int i = l; i < n - l - 1; i++)
                {
                    Swap(ref a[i, m - l - 1], ref a[i + 1, m - l - 1]);
                }

                // 아래쪽 라인
                for (int j = m - l - 1; j >= l + 1; j--)
                {
                    Swap(ref a[n - l - 1, j], ref a[n - l - 1, j - 1]);
                }

                // 왼쪽 라인
                for (int i = n - l - 1; i >= l + 1 + 1; i--)
                {
                    Swap(ref a[i, l], ref a[i - 1, l]);
                }
                round--;
            }

            if (l < layer - 1) Turn(l + 1);
        }

        private static void Swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }

        public static void Solution()
        {
            int[] nmr = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

            n = nmr[0];
            m = nmr[1];
            r = nmr[2];
            a = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                int[] aij = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = aij[j];
                }
            }

            layer = (n > m) ? m / 2 : n / 2;

            Turn(0);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    sw.Write($"{a[i, j]} ");
                }
                sw.WriteLine();
            }

            sw.Close();
            sr.Close();
        }
    }
}
