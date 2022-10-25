using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BaekjoonCs
{
    class _10973
    {
        private static StreamReader sr = new StreamReader(Console.OpenStandardInput());
        private static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

        private static void Swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }

        public static void Solution()
        {
            int n = int.Parse(sr.ReadLine());
            int[] array = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

            int[] answer = new int[n];

            int index = n - 1;
            while (index > 0 && !(array[index - 1] > array[index])) index--;

            if (index > 0)
            {
                for (int i = n - 1; i >= 0; i--)
                {
                    if (array[index - 1] > array[i])
                    {
                        Swap(ref array[index - 1], ref array[i]);
                        break;
                    }
                }
                int remainSize = n - 1 - index;

                for (int i = 0; i <= remainSize / 2; i++)
                {
                    Swap(ref array[index + i], ref array[n - 1 - i]);
                }
                string str = "";
                for (int i = 0; i < n; i++)
                {
                    str += array[i] + " ";
                }
                sw.WriteLine(str);
            }
            else sw.WriteLine(-1);


            sw.Close();
            sr.Close();
        }
    }
}
