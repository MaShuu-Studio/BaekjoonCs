using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BaekjoonCs
{
    class _2667
    {
        private static StreamReader sr = new StreamReader(Console.OpenStandardInput());
        private static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

        private static int n;
        private static int[,] map;
        private static List<int> houses;
        private static bool[,] visited;
        private static int count;

        private static void Search()
        {
            count = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (visited[i, j] == false)
                    {
                        map[i, j] = count;
                        houses.Add(0);
                        Extend(i, j);
                        count++;
                    }
                }
            }
        }

        private static void Extend(int i, int j)
        {
            visited[i, j] = true;
            map[i, j] = count;
            houses[count - 1]++;

            if (i > 0 && !visited[i - 1, j]) Extend(i - 1, j);
            if (i < n - 1 && !visited[i + 1, j]) Extend(i + 1, j);
            if (j > 0 && !visited[i, j - 1]) Extend(i, j - 1);
            if (j < n - 1 && !visited[i, j + 1]) Extend(i, j + 1);
        }

        public static void Solution()
        {
            n = int.Parse(sr.ReadLine());
            map = new int[n, n];
            visited = new bool[n, n];
            houses = new List<int>();
            for (int i = 0; i < n; i++)
            {
                string s = sr.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    map[i, j] = s[j] - '0';
                    if (map[i, j] == 0) visited[i, j] = true;
                }
            }

            Search();
            sw.WriteLine(houses.Count);
            houses.Sort();
            for (int i = 0; i < houses.Count; i++)
                sw.WriteLine(houses[i]);
            sw.Close();
            sr.Close();
        }
    }
}
