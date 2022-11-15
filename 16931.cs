using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BaekjoonCs
{
    class _16931
    {
        private static StreamReader sr = new StreamReader(Console.OpenStandardInput());
        private static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

        private static int n, m;
        private static int[,] a;

        private static int Area()
        {
            int area = 0;

            // 위 아래면
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    area += 2;

            // 뒤쪽 면
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i == 0)
                        area += a[i, j];
                    else if (a[i, j] > a[i - 1, j])
                        area += a[i, j] - a[i - 1, j];
                }
            }

            // 앞쪽 면
            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i == n - 1)
                        area += a[i, j];
                    else if (a[i, j] > a[i + 1, j])
                        area += a[i, j] - a[i + 1, j];
                }
            }

            // 왼쪽 면
            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    if (j == 0)
                        area += a[i, j];
                    else if (a[i, j] > a[i, j - 1])
                        area += a[i, j] - a[i, j - 1];
                }
            }
            // 오른쪽 면
            for (int j = m - 1; j >= 0; j--)
            {
                for (int i = 0; i < n; i++)
                {
                    if (j == m - 1)
                        area += a[i, j];
                    else if (a[i, j] > a[i, j + 1])
                        area += a[i, j] - a[i, j + 1];
                }
            }

            return area;
        }

        public static void Solution()
        {
            int[] nm = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

            n = nm[0];
            m = nm[1];

            a = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                int[] anm = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = anm[j];
                }
            }

            sw.WriteLine(Area());

            sw.Close();
            sr.Close();
        }
    }
}
