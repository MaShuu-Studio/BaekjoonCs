using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BaekjoonCs
{
    class _2178
    {
        private static StreamReader sr = new StreamReader(Console.OpenStandardInput());
        private static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

        private static int n, m;
        private static int[,] map;
        private static int[,] save;
        private static void Search(int i, int j, int count)
        {
            save[i, j] = count;

            if (i > 0 && map[i - 1, j] != -1 && save[i - 1, j] > count + 1) Search(i - 1, j, count + 1);
            if (i < n - 1 && map[i + 1, j] != -1 && save[i + 1, j] > count + 1) Search(i + 1, j, count + 1);
            if (j > 0 && map[i, j - 1] != -1 && save[i, j - 1] > count + 1) Search(i, j - 1, count + 1);
            if (j < m - 1 && map[i, j + 1] != -1 && save[i, j + 1] > count + 1) Search(i, j + 1, count + 1);
        }
        public static void Solution()
        {
            int[] nm = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            n = nm[0];
            m = nm[1];
            map = new int[n, m];
            save = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                string s = sr.ReadLine();
                for (int j = 0; j < m; j++)
                {
                    map[i, j] = s[j] - '0';
                    if (map[i, j] == 0) save[i, j] = -1;
                    else save[i, j] = 10001;
                }
            }
            Search(0, 0, 1);

            sw.WriteLine(save[n - 1, m - 1]);
            sw.Close();
            sr.Close();
        }
    }
}
