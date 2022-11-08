using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BaekjoonCs
{
    class _1912
    {
        private static StreamReader sr = new StreamReader(Console.OpenStandardInput());
        private static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

        public static void Solution()
        {
            int n = int.Parse(sr.ReadLine());

            int[] array = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int[] save = new int[n];

            save[0] = array[0];
            int answer = save[0];
            for (int i = 1; i < n; i++)
            {
                int max = array[i];
                if (save[i - 1] > 0) max = max + save[i-1];

                if (answer < max) answer = max;
                save[i] = max;
            }

            sw.WriteLine(answer);
            sw.Close();
            sr.Close();
        }
    }
}
