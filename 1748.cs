using System;
using System.Collections.Generic;
using System.Text;

namespace BaekjoonCs
{
    class _1748
    {
        public static void Solution()
        {
            int answer = 0;
            int n = int.Parse(Console.ReadLine());

            int tmp = n;
            int digit = 0;
            do
            {
                tmp /= 10;
                digit++;

                if (tmp > 0)
                {
                    int amount = 9 * (int)Math.Pow(10, digit - 1);

                    answer += digit * amount;
                    n -= amount;
                }
            } 
            while (tmp > 0);

            answer += digit * n;

            Console.WriteLine(answer);
        }
    }
}
