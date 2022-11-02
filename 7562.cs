using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BaekjoonCs
{
    class _7562
    {
        private static StreamReader sr = new StreamReader(Console.OpenStandardInput());
        private static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

        private static bool[,] visited;

        private static int Search(int l, int[] start, int[] end)
        {
            Queue<Tuple<int, int>> q = new Queue<Tuple<int, int>>();
            q.Enqueue(new Tuple<int, int>(start[0], start[1]));

            int answer = 0;

            while (true)
            {
                answer++;
                int size = q.Count;

                for (int i = 0; i < size; i++)
                {
                    Tuple<int, int> item = q.Dequeue();
                    int originx = item.Item1;
                    int originy = item.Item2;

                    int x;
                    int y;

                    x = originx - 1;
                    y = originy + 2;

                    if (x == end[0] && y == end[1]) return answer;
                    if (x >= 0 && y < l && !visited[x, y])
                    {
                        q.Enqueue(new Tuple<int, int>(x, y));
                        visited[x, y] = true;
                    }

                    x = originx - 1;
                    y = originy - 2;
                    if (x == end[0] && y == end[1]) return answer;
                    if (x >= 0 && y >= 0 && !visited[x, y])
                    {
                        q.Enqueue(new Tuple<int, int>(x, y));
                        visited[x, y] = true;
                    }

                    x = originx - 2;
                    y = originy + 1;
                    if (x == end[0] && y == end[1]) return answer;
                    if (x >= 0 && y < l && !visited[x, y])
                    {
                        q.Enqueue(new Tuple<int, int>(x, y));
                        visited[x, y] = true;
                    }

                    x = originx - 2;
                    y = originy - 1;
                    if (x == end[0] && y == end[1]) return answer;
                    if (x >= 0 && y >= 0 && !visited[x, y])
                    {
                        q.Enqueue(new Tuple<int, int>(x, y));
                        visited[x, y] = true;
                    }

                    x = originx + 1;
                    y = originy + 2;
                    if (x == end[0] && y == end[1]) return answer;
                    if (x < l && y < l && !visited[x, y])
                    {
                        q.Enqueue(new Tuple<int, int>(x, y));
                        visited[x, y] = true;
                    }

                    x = originx + 1;
                    y = originy - 2;
                    if (x == end[0] && y == end[1]) return answer;
                    if (x < l && y >= 0 && !visited[x, y])
                    {
                        q.Enqueue(new Tuple<int, int>(x, y));
                        visited[x, y] = true;
                    }

                    x = originx + 2;
                    y = originy + 1;
                    if (x == end[0] && y == end[1]) return answer;
                    if (x < l && y < l && !visited[x, y])
                    {
                        q.Enqueue(new Tuple<int, int>(x, y));
                        visited[x, y] = true;
                    }

                    x = originx + 2;
                    y = originy - 1;
                    if (x == end[0] && y == end[1]) return answer;
                    if (x < l && y >= 0 && !visited[x, y])
                    {
                        q.Enqueue(new Tuple<int, int>(x, y));
                        visited[x, y] = true;
                    }
                }
            }
            return answer;
        }

        public static void Solution()
        {
            int n = int.Parse(sr.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int l = int.Parse(sr.ReadLine());
                int[] start = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                int[] end = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

                int answer = 0;
                if (!(start[0] == end[0] && start[1] == end[1]))
                {
                    visited = new bool[l, l];
                    answer = Search(l, start, end);
                }

                sw.WriteLine(answer);
            }
            sw.Close();
            sr.Close();
        }
    }
}
