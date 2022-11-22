using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BaekjoonCs
{
    class _1697
    {
        private static StreamReader sr = new StreamReader(Console.OpenStandardInput());
        private static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

        private static int n, k, answer;
        private static Queue<int> q;
        private static bool[] save;

        public static void Solution()
        {
            int[] nk = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            n = nk[0];
            k = nk[1];
            answer = 0;

            save = new bool[100001];
            q = new Queue<int>();

            q.Enqueue(n);
            save[n] = true;

            int qsize = q.Count;
            bool find = false;

            if (n != k)
                while (find == false && qsize != 0)
                {
                    qsize = q.Count;
                    answer++;

                    for (int i = 0; i < qsize; i++)
                    {
                        int pos = q.Dequeue();

                        if (pos > 0 && save[pos - 1] == false)
                        {
                            save[pos - 1] = true;
                            q.Enqueue(pos - 1);
                            find = (pos - 1 == k);
                            if (find) break;
                        }

                        if (pos < 100000 && save[pos + 1] == false)
                        {
                            save[pos + 1] = true;
                            q.Enqueue(pos + 1);
                            find = (pos + 1 == k);
                            if (find) break;
                        }

                        if (pos * 2 <= 100000 && save[pos * 2] == false)
                        {
                            save[pos * 2] = true;
                            q.Enqueue(pos * 2);
                            find = (pos * 2 == k);
                            if (find) break;
                        }
                    }
                }

            sw.WriteLine(answer);
            sw.Close();
            sr.Close();

        }
    }
}
