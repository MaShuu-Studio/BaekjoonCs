using System;
using System.Collections.Generic;
using System.Text;

namespace BaekjoonCs
{
    class _15655
    {
        private static StringBuilder sb = new StringBuilder();
        private static int n, m;
        private static int[] array = new int[8];
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

            for (int i = num; i < n; i++)
            {
                if (Contains(array[i], count)) continue;

                container[count] = array[i];
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

            array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Array.Sort(array);

            DFS(0, 0);
            Console.WriteLine(sb);
        }
    }
}
