using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BaekjoonCs
{
    class _2133
    {
        private static StreamReader sr = new StreamReader(Console.OpenStandardInput());
        private static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

        private static int[] save;

        public static void Solution()
        {
            int n = int.Parse(sr.ReadLine());

            save = new int[n + 1];

            if (n >= 2) save[2] = 3;

            for (int i = 4; i <= n; i += 2)
            {
                save[i] = save[i - 2] * save[2]; // 가장 뒤에 2개 짜리를 붙임
                for (int j = 4; j <= i - 2; j += 2) // 가장 뒤에 각각의 고유방식의 타일을 붙임.
                {
                    save[i] += save[i - j] * 2; // 해당 고유 방식은 항상 2개임
                }
                save[i] += 2; // 새로 생기는 고유 방식
            }

            sw.WriteLine(save[n]);
            sw.Close();
            sr.Close();
        }
    }
}
