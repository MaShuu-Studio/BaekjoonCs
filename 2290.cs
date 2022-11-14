using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BaekjoonCs
{
    class _2290
    {
        private static StreamReader sr = new StreamReader(Console.OpenStandardInput());
        private static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

        private static int s, n, digit;
        private static int[] num;

        private static void SetDigit()
        {
            Stack<int> tmp = new Stack<int>();

            while(n > 0)
            {
                int m = n % 10;
                n /= 10;
                digit++;

                tmp.Push(m);
            }

            num = new int[digit];
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = tmp.Pop();
            }
        }

        private static void Print(int num, int row)
        {
            row = row + 1;
            // 0: 가로, 1: 세로 위, 2: 가로 중앙, 3: 세로 아래, 4:가로 아래
            int pos = 0;
            if (row == 1) pos = 0;
            else if (row < s + 2) pos = 1;
            else if (row == s + 2) pos = 2;
            else if (row < 2 * s + 3) pos = 3;
            else pos = 4;

            switch (num)
            {
                case 1:
                    if (pos == 0)
                    {
                        sw.Write(" ");
                        for (int i = 0; i < s; i++) sw.Write(" ");
                        sw.Write(" ");
                    }
                    else if (pos == 1)
                    {
                        sw.Write(" ");
                        for (int i = 0; i < s; i++) sw.Write(" ");
                        sw.Write("|");
                    }
                    else if (pos == 2)
                    {
                        sw.Write(" ");
                        for (int i = 0; i < s; i++) sw.Write(" ");
                        sw.Write(" ");
                    }
                    else if (pos == 3)
                    {
                        sw.Write(" ");
                        for (int i = 0; i < s; i++) sw.Write(" ");
                        sw.Write("|");
                    }
                    else if (pos == 4)
                    {
                        sw.Write(" ");
                        for (int i = 0; i < s; i++) sw.Write(" ");
                        sw.Write(" ");
                    }
                    break;
                case 2:
                    if (pos == 0)
                    {
                        sw.Write(" ");
                        for (int i = 0; i < s; i++) sw.Write("-");
                        sw.Write(" ");
                    }
                    else if (pos == 1)
                    {
                        sw.Write(" ");
                        for (int i = 0; i < s; i++) sw.Write(" ");
                        sw.Write("|");
                    }
                    else if (pos == 2)
                    {
                        sw.Write(" ");
                        for (int i = 0; i < s; i++) sw.Write("-");
                        sw.Write(" ");
                    }
                    else if (pos == 3)
                    {
                        sw.Write("|");
                        for (int i = 0; i < s; i++) sw.Write(" ");
                        sw.Write(" ");
                    }
                    else if (pos == 4)
                    {
                        sw.Write(" ");
                        for (int i = 0; i < s; i++) sw.Write("-");
                        sw.Write(" ");
                    }
                    break;
                case 3:
                    if (pos == 0)
                    {
                        sw.Write(" ");
                        for (int i = 0; i < s; i++) sw.Write("-");
                        sw.Write(" ");
                    }
                    else if (pos == 1)
                    {
                        sw.Write(" ");
                        for (int i = 0; i < s; i++) sw.Write(" ");
                        sw.Write("|");
                    }
                    else if (pos == 2)
                    {
                        sw.Write(" ");
                        for (int i = 0; i < s; i++) sw.Write("-");
                        sw.Write(" ");
                    }
                    else if (pos == 3)
                    {
                        sw.Write(" ");
                        for (int i = 0; i < s; i++) sw.Write(" ");
                        sw.Write("|");
                    }
                    else if (pos == 4)
                    {
                        sw.Write(" ");
                        for (int i = 0; i < s; i++) sw.Write("-");
                        sw.Write(" ");
                    }
                    break;
                case 4:
                    if (pos == 0)
                    {
                        sw.Write(" ");
                        for (int i = 0; i < s; i++) sw.Write(" ");
                        sw.Write(" ");
                    }
                    else if (pos == 1)
                    {
                        sw.Write("|");
                        for (int i = 0; i < s; i++) sw.Write(" ");
                        sw.Write("|");
                    }
                    else if (pos == 2)
                    {
                        sw.Write(" ");
                        for (int i = 0; i < s; i++) sw.Write("-");
                        sw.Write(" ");
                    }
                    else if (pos == 3)
                    {
                        sw.Write(" ");
                        for (int i = 0; i < s; i++) sw.Write(" ");
                        sw.Write("|");
                    }
                    else if (pos == 4)
                    {
                        sw.Write(" ");
                        for (int i = 0; i < s; i++) sw.Write(" ");
                        sw.Write(" ");
                    }
                    break;
                case 5:
                    if (pos == 0)
                    {
                        sw.Write(" ");
                        for (int i = 0; i < s; i++) sw.Write("-");
                        sw.Write(" ");
                    }
                    else if (pos == 1)
                    {
                        sw.Write("|");
                        for (int i = 0; i < s; i++) sw.Write(" ");
                        sw.Write(" ");
                    }
                    else if (pos == 2)
                    {
                        sw.Write(" ");
                        for (int i = 0; i < s; i++) sw.Write("-");
                        sw.Write(" ");
                    }
                    else if (pos == 3)
                    {
                        sw.Write(" ");
                        for (int i = 0; i < s; i++) sw.Write(" ");
                        sw.Write("|");
                    }
                    else if (pos == 4)
                    {
                        sw.Write(" ");
                        for (int i = 0; i < s; i++) sw.Write("-");
                        sw.Write(" ");
                    }
                    break;
                case 6:
                    if (pos == 0)
                    {
                        sw.Write(" ");
                        for (int i = 0; i < s; i++) sw.Write("-");
                        sw.Write(" ");
                    }
                    else if (pos == 1)
                    {
                        sw.Write("|");
                        for (int i = 0; i < s; i++) sw.Write(" ");
                        sw.Write(" ");
                    }
                    else if (pos == 2)
                    {
                        sw.Write(" ");
                        for (int i = 0; i < s; i++) sw.Write("-");
                        sw.Write(" ");
                    }
                    else if (pos == 3)
                    {
                        sw.Write("|");
                        for (int i = 0; i < s; i++) sw.Write(" ");
                        sw.Write("|");
                    }
                    else if (pos == 4)
                    {
                        sw.Write(" ");
                        for (int i = 0; i < s; i++) sw.Write("-");
                        sw.Write(" ");
                    }
                    break;
                case 7:
                    if (pos == 0)
                    {
                        sw.Write(" ");
                        for (int i = 0; i < s; i++) sw.Write("-");
                        sw.Write(" ");
                    }
                    else if (pos == 1)
                    {
                        sw.Write(" ");
                        for (int i = 0; i < s; i++) sw.Write(" ");
                        sw.Write("|");
                    }
                    else if (pos == 2)
                    {
                        sw.Write(" ");
                        for (int i = 0; i < s; i++) sw.Write(" ");
                        sw.Write(" ");
                    }
                    else if (pos == 3)
                    {
                        sw.Write(" ");
                        for (int i = 0; i < s; i++) sw.Write(" ");
                        sw.Write("|");
                    }
                    else if (pos == 4)
                    {
                        sw.Write(" ");
                        for (int i = 0; i < s; i++) sw.Write(" ");
                        sw.Write(" ");
                    }
                    break;
                case 8:
                    if (pos == 0)
                    {
                        sw.Write(" ");
                        for (int i = 0; i < s; i++) sw.Write("-");
                        sw.Write(" ");
                    }
                    else if (pos == 1)
                    {
                        sw.Write("|");
                        for (int i = 0; i < s; i++) sw.Write(" ");
                        sw.Write("|");
                    }
                    else if (pos == 2)
                    {
                        sw.Write(" ");
                        for (int i = 0; i < s; i++) sw.Write("-");
                        sw.Write(" ");
                    }
                    else if (pos == 3)
                    {
                        sw.Write("|");
                        for (int i = 0; i < s; i++) sw.Write(" ");
                        sw.Write("|");
                    }
                    else if (pos == 4)
                    {
                        sw.Write(" ");
                        for (int i = 0; i < s; i++) sw.Write("-");
                        sw.Write(" ");
                    }
                    break;
                case 9:
                    if (pos == 0)
                    {
                        sw.Write(" ");
                        for (int i = 0; i < s; i++) sw.Write("-");
                        sw.Write(" ");
                    }
                    else if (pos == 1)
                    {
                        sw.Write("|");
                        for (int i = 0; i < s; i++) sw.Write(" ");
                        sw.Write("|");
                    }
                    else if (pos == 2)
                    {
                        sw.Write(" ");
                        for (int i = 0; i < s; i++) sw.Write("-");
                        sw.Write(" ");
                    }
                    else if (pos == 3)
                    {
                        sw.Write(" ");
                        for (int i = 0; i < s; i++) sw.Write(" ");
                        sw.Write("|");
                    }
                    else if (pos == 4)
                    {
                        sw.Write(" ");
                        for (int i = 0; i < s; i++) sw.Write("-");
                        sw.Write(" ");
                    }
                    break;
                case 0:
                    if (pos == 0)
                    {
                        sw.Write(" ");
                        for (int i = 0; i < s; i++) sw.Write("-");
                        sw.Write(" ");
                    }
                    else if (pos == 1)
                    {
                        sw.Write("|");
                        for (int i = 0; i < s; i++) sw.Write(" ");
                        sw.Write("|");
                    }
                    else if (pos == 2)
                    {
                        sw.Write(" ");
                        for (int i = 0; i < s; i++) sw.Write(" ");
                        sw.Write(" ");
                    }
                    else if (pos == 3)
                    {
                        sw.Write("|");
                        for (int i = 0; i < s; i++) sw.Write(" ");
                        sw.Write("|");
                    }
                    else if (pos == 4)
                    {
                        sw.Write(" ");
                        for (int i = 0; i < s; i++) sw.Write("-");
                        sw.Write(" ");
                    }
                    break;
            }
        }

        public static void Solution()
        {
            int[] sn = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

            s = sn[0];
            n = sn[1];

            SetDigit();

            for (int i = 0; i < 2 * s + 3; i++)
            {
                for (int j = 0; j < digit; j++)
                {
                    Print(num[j], i);
                    sw.Write(" ");
                }
                sw.WriteLine();
            }

            sw.Close();
            sr.Close();
        }
    }
}
