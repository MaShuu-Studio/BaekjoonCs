using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BaekjoonCs
{
    class _1182
    {
        private static StreamReader sr = new StreamReader(Console.OpenStandardInput());
        private static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

        private static int n, s;
        private static int[] array;
        private static List<int> cur = new List<int>();
        private static int answer;

        private static void Search(int pos, int count)
        {
            if (cur.Count > 0 && Sum() == s) answer++;
            if (n == cur.Count) return;

            for (int i = pos; i < n; i++)
            {
                cur.Add(array[i]);
                Search(i + 1, count + 1);
                cur.Remove(array[i]);
            }
        }

        private static int Sum()
        {
            int num = 0;
            for (int i = 0; i < cur.Count; i++)
            {
                num += cur[i];
            }

            return num;
        }

        public static void Solution()
        {
            int[] ns = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

            n = ns[0];
            s = ns[1];

            array = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

            answer = 0;

            Search(0, 0);

            sw.WriteLine(answer);
            sw.Close();
            sr.Close();
        }
    }
}

