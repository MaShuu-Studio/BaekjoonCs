using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BaekjoonCs
{
    class _1932
    {
        private static StreamReader sr = new StreamReader(Console.OpenStandardInput());
        private static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

        private static int[,] tri;
        private static int[,] save;

        public static void Solution()
        {
            int n = int.Parse(sr.ReadLine());
            tri = new int[n, n];
            save = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                int[] ti = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                for (int j = 0; j < ti.Length; j++)
                {
                    tri[i, j] = ti[j];
                }
            }

            save[0, 0] = tri[0, 0];
            for (int i = 1; i < n;  i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    int max = 0;
                    for (int k = j-1; k <= j; k++)
                    {
                        if (k < 0) continue;
                        if (max < tri[i, j] + save[i - 1, k]) max = tri[i, j] + save[i - 1, k];
                    }
                    save[i, j] = max;
                }    
            }

            int answer = 0;
            for (int j = 0; j < n; j++)
            {
                if (answer < save[n - 1, j]) answer = save[n - 1, j];
            }
            
            sw.WriteLine(answer);
            sw.Close();
            sr.Close();
        }
    }
}
