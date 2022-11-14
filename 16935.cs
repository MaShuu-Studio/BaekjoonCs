using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BaekjoonCs
{
    class _16935
    {
        private static StreamReader sr = new StreamReader(Console.OpenStandardInput());
        private static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

        private static int n, m, r;
        private static int[,] a;

        private static void Func(int f)
        {
            switch (f)
            {
                case 1:
                    UpDown();
                    break;
                case 2:
                    LeftRight();
                    break;
                case 3:
                    Right();
                    break;
                case 4:
                    Left();
                    break;
                case 5:
                    GroupRight();
                    break;
                case 6:
                    GroupLeft();
                    break;
            }
        }

        private static void UpDown()
        {
            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Swap(ref a[i, j], ref a[n - 1 - i, j]);
                }
            }
        }
        private static void LeftRight()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m / 2; j++)
                {
                    Swap(ref a[i, j], ref a[i, m - 1 - j]);
                }
            }
        }
        private static void Right()
        {
            UpDown();
            int[,] b = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    b[i, j] = a[j, i];
                }
            }

            a = b;
            Swap(ref n, ref m);
        }

        private static void Left()
        {
            LeftRight();
            int[,] b = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    b[i, j] = a[j, i];
                }
            }
            a = b;
            Swap(ref n, ref m);

        }
        private static void GroupRight()
        {
            // 그룹단위 위아래 대칭
            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n / 2; i++)
                {
                    Swap(ref a[i, j], ref a[i + n / 2, j]);
                }
            }

            // 오른쪽위, 왼쪽아래 스왑
            for (int i = n / 2; i < n; i++)
            {
                for (int j = 0; j < m / 2; j++)
                {
                    Swap(ref a[i, j], ref a[i - n / 2, j + m / 2]);
                }
            }
        }
        private static void GroupLeft()
        {
            // 그룹단위 좌우 대칭
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m / 2; j++)
                {
                    Swap(ref a[i, j], ref a[i, j + m / 2]);
                }
            }

            // 오른쪽위, 왼쪽아래 스왑
            for (int i = n / 2; i < n; i++)
            {
                for (int j = 0; j < m / 2; j++)
                {
                    Swap(ref a[i, j], ref a[i - n / 2, j + m / 2]);
                }
            }
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
                int[] row = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                for (int j = 0; j < m; j++)
                    a[i, j] = row[j];
            }

            int[] func = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            for (int j = 0; j < func.Length; j++)
            {
                Func(func[j]);
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
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
