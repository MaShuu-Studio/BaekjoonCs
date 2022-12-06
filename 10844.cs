using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BaekjoonCs
{
    class _10844
    {
        private static StreamReader sr = new StreamReader(Console.OpenStandardInput());
        private static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

        private static long[] save;
        private const int REMAIN = 1000000000;

        private static void Search(int n)
        {
            if (n <= 0) return;

            long[] tmp = new long[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            for (int i = 0; i <= 9; i++)
            {
                if (i - 1 >= 0) tmp[i - 1] += save[i] % REMAIN;
                if (i + 1 <= 9) tmp[i + 1] += save[i] % REMAIN;
            }

            save = tmp;
            Search(n - 1);
        }

        private static long Answer()
        {
            long answer = 0;
            for (int i = 0; i <= 9; i++)
                answer += save[i];

            return answer % REMAIN;
        }

        public static void Solution()
        {
            int n = int.Parse(sr.ReadLine());
            save = new long[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            n--;
            for (int i = 1; i <= 9; i++)
            {
                save[i]++;
            }

            Search(n);

            sw.WriteLine(Answer());
            sw.Close();
            sr.Close();
        }
    }
}
