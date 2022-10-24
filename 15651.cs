using System;
using System.Collections.Generic;
using System.Text;

namespace BaekjoonCs
{
    class _15651
    {
        private static StringBuilder sb = new StringBuilder();
        private static int n, m;
        private static int[] container = new int[8];

        private static void DFS(int num, int count)
        {
            if (count == m)
            {
                for (int i = 0; i < count; i++)
                {
                    sb.Append($"{container[i]} ");
                }
                sb.AppendLine();
                return;
            }

            for (int i = 1; i <= n; i++)
            {
                container[count] = i;
                DFS(i, count + 1);
                container[count] = 0;
            }
        }

        private static bool Contains(int num, int count)
        {
            for (int i = 0; i < count; i++)
            {
                if (container[i] == num) return true;
            }
            return false;
        }

        public static void Solution()
        {
            int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            n = nm[0];
            m = nm[1];

            DFS(1, 0);
            Console.WriteLine(sb);
        }
    }
}
