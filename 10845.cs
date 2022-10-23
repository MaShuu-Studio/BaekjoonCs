using System;
using System.Collections.Generic;
using System.Text;

namespace BaekjoonCs
{
    class _10845
    {
        public static void Solution()
        {
            int n = int.Parse(Console.ReadLine());

            List<int> q = new List<int>();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                string[] func = Console.ReadLine().Split();

                int max = q.Count - 1;
                int item = -1;

                switch(func[0])
                {
                    case "push":
                        q.Add(int.Parse(func[1]));
                        break;
                    case "pop":
                        if (q.Count > 0)
                        {
                            item = q[0];
                            q.RemoveAt(0);
                        }
                        sb.AppendLine(item.ToString());
                        break;
                    case "size":
                        sb.AppendLine(q.Count.ToString());
                        break;
                    case "empty":
                        int empty = (q.Count > 0) ? 0 : 1;
                        sb.AppendLine(empty.ToString());
                        break;
                    case "front":
                        if (q.Count > 0) item = q[0];
                        sb.AppendLine(item.ToString());
                        break;
                    case "back":
                        if (q.Count > 0) item = q[max];
                        sb.AppendLine(item.ToString());
                        break;
                }
            }

            Console.WriteLine(sb);
        }
    }
}
