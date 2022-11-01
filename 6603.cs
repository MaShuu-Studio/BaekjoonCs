using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BaekjoonCs
{
    class _6603
    {
        private static StreamReader sr = new StreamReader(Console.OpenStandardInput());
        private static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
        private static StringBuilder sb = new StringBuilder();

        private static int k;
        private static int[] s;
        private static List<int> nums = new List<int>();

        private static void Search(int cur)
        {
            if (nums.Count == 6)
            {
                for (int i = 0; i < 6; i++)
                {
                    sb.Append(s[nums[i]] + " ");
                }
                sb.AppendLine();
                return;
            }

            for (int i = cur; i < s.Length; i++)
            {
                if (nums.Count + s.Length - i < 6) return;
                nums.Add(i);
                Search(i + 1);
                nums.Remove(i);
            }
        }

        public static void Solution()
        {

            while (true)
            {
                int[] list = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

                if (list[0] == 0) break;

                k = list[0];
                s = new int[k];
                for (int i = 0; i < k; i++)
                {
                    s[i] = list[i + 1];
                }

                Search(0);
                sb.AppendLine();
            }

            sw.WriteLine(sb);
            sw.Close();
            sr.Close();
        }
    }
}
