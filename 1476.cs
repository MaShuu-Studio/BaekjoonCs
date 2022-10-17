using System;
using System.Collections.Generic;
using System.Text;

namespace BaekjoonCs
{
    class _1476
    {
        public static void Solution()
        {
            const int E = 15, S = 28, M = 19;
            int e, s, m;

            int answer = 1;

            int[] esm = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            while (esm[0] != 1 || esm[1] != 1 || esm[2] != 1)
            {
                answer++;

                esm[0]--;
                esm[1]--;
                esm[2]--;

                if (esm[0] == 0) esm[0] = E;
                if (esm[1] == 0) esm[1] = S;
                if (esm[2] == 0) esm[2] = M;
            }

            Console.WriteLine(answer);
        }
    }
}
