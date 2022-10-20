using System;
using System.Collections.Generic;
using System.Text;

namespace BaekjoonCs
{
    class _3085
    {
        private static char[,] candies = new char[50, 50];
        private static int n;
        private static int max;

        public static void Solution()
        {
            n = int.Parse(Console.ReadLine());
            max = 0;

            for (int i = 0; i < n; i++)
            {
                string str = Console.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    candies[i, j] = str[j];
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    char tmp = candies[i, j];
                    candies[i, j] = candies[i, j + 1];
                    candies[i, j + 1] = tmp;

                    Check(i, j);

                    candies[i, j + 1] = candies[i, j];
                    candies[i, j] = tmp;
                }
            }

            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    char tmp = candies[i, j];
                    candies[i, j] = candies[i + 1, j];
                    candies[i + 1, j] = tmp;

                    Check(i, j);

                    candies[i + 1, j] = candies[i, j];
                    candies[i, j] = tmp;
                }
            }

            Console.WriteLine(max);
        }


        private static void Check(int y, int x)
        {
            for (int i = 0; i < n; i++)
            {
                int size = 0;
                char c = ' ';
                for (int j = 0; j < n; j++)
                {
                    char candy = candies[i, j];
                    if (c != candy)
                    {
                        c = candy;
                        size = 0;
                    }

                    size++;
                    if (max < size) max = size;
                }
            }

            for (int j = 0; j < n; j++)
            {
                int size = 0;
                char c = ' ';
                for (int i = 0; i < n; i++)
                {
                    char candy = candies[i, j];
                    if (c != candy)
                    {
                        c = candy;
                        size = 0;
                    }

                    size++;
                    if (max < size) max = size;
                }
            }
        }
    }
}
