using System;
using System.Collections.Generic;
using System.Text;

namespace BaekjoonCs
{
    class _9095
    {
        private static int[] answer = new int[11];

        public static void Solution()
        {
            int t = int.Parse(Console.ReadLine());

            answer[0] = 0;
            answer[1] = 1;
            answer[2] = 2;
            answer[3] = 4;

            for (int i = 4; i < 11; i++)
            {
                answer[i] = answer[i - 1] + answer[i - 2] + answer[i - 3];
            }

            for (int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine(answer[n]);
            }
        }
    }
}
