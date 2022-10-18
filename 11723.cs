using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BaekjoonCs
{
    class _11723
    {
        public static void Solution()
        {
            int m = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();
            int[] s = new int[21];

            for (int i = 0; i < m; i++)
            {
                string[] input = Console.ReadLine().Split();

                string func = input[0];
                int x = 0;
                if (input.Length > 1) x = int.Parse(input[1]);

                switch (func)
                {
                    case "add":
                        s[x] = 1;
                        break;
                    case "remove":
                        s[x] = 0;
                        break;
                    case "check":
                        int tf = s[x];
                        sb.AppendLine(tf.ToString());
                        break;
                    case "toggle":
                        s[x] = (s[x] + 1) % 2;
                        break;
                    case "all":
                        for (int n = 1; n <= 20; n++)
                            s[n] = 1;
                        break;
                    case "empty":
                        for (int n = 1; n <= 20; n++)
                            s[n] = 0;
                        break;
                }
            }

            Console.WriteLine(sb);
        }
    }
}
