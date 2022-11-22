using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BaekjoonCs
{
    class _7576
    {
        private static StreamReader sr = new StreamReader(Console.OpenStandardInput());
        private static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

        private static int n, m;
        private static int[,] tomato;
        private static int answer;
        private static Queue<Tuple<int, int>> q;

        private static void Search()
        {
            int qsize = 1;

            while (!Check() && qsize != 0)
            {
                qsize = q.Count;

                for (int i = 0; i < qsize; i++)
                {
                    Tuple<int, int> item = q.Dequeue();
                    int y = item.Item1;
                    int x = item.Item2;

                    if (y > 0 && tomato[y - 1, x] == 0)
                    {
                        tomato[y - 1, x] = 1;
                        q.Enqueue(new Tuple<int, int>(y - 1, x));
                    }
                    if (y < n - 1 && tomato[y + 1, x] == 0)
                    {
                        tomato[y + 1, x] = 1;
                        q.Enqueue(new Tuple<int, int>(y + 1, x));
                    }
                    if (x > 0 && tomato[y, x - 1] == 0)
                    {
                        tomato[y, x - 1] = 1;
                        q.Enqueue(new Tuple<int, int>(y, x - 1));
                    }
                    if (x < m - 1 && tomato[y, x + 1] == 0)
                    {
                        tomato[y, x + 1] = 1;
                        q.Enqueue(new Tuple<int, int>(y, x + 1));
                    }
                }
                answer++;
            }
        }

        private static bool Check()
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    if (tomato[i, j] == 0) return false;
                }

            return true;
        }

        public static void Solution()
        {
            int[] mn = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

            m = mn[0];
            n = mn[1];
            answer = 0;
            tomato = new int[n, m];
            q = new Queue<Tuple<int, int>>();

            for (int i = 0; i < n; i++)
            {
                int[] t = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                for (int j = 0; j < m; j++)
                {
                    tomato[i, j] = t[j];
                    if (tomato[i, j] == 1) q.Enqueue(new Tuple<int, int>(i, j));
                }
            }

            Search();

            if (Check()) sw.WriteLine(answer);
            else sw.WriteLine(-1);
            sw.Close();
            sr.Close();
        }
    }
}
