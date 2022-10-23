using System;
using System.Collections.Generic;
using System.Text;

namespace BaekjoonCs
{
    class _10866
    {
        public static void Solution()
        {
            int n = int.Parse(Console.ReadLine());

            List<int> deck = new List<int>();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                string[] func = Console.ReadLine().Split();

                int max = deck.Count - 1;
                int item = -1;

                switch (func[0])
                {
                    case "push_front":
                        List<int> tmp = new List<int>();
                        tmp.Add(int.Parse(func[1]));
                        tmp.AddRange(deck);
                        deck = tmp;
                        break;
                    case "push_back":
                        deck.Add(int.Parse(func[1]));
                        break;
                    case "pop_front":
                        if (deck.Count > 0)
                        {
                            item = deck[0];
                            deck.RemoveAt(0);
                        }
                        sb.AppendLine(item.ToString());
                        break;
                    case "pop_back":
                        if (deck.Count > 0)
                        {
                            item = deck[max];
                            deck.RemoveAt(max);
                        }
                        sb.AppendLine(item.ToString());
                        break;
                    case "size":
                        sb.AppendLine(deck.Count.ToString());
                        break;
                    case "empty":
                        int empty = (deck.Count > 0) ? 0 : 1;
                        sb.AppendLine(empty.ToString());
                        break;
                    case "front":
                        if (deck.Count > 0) item = deck[0];
                        sb.AppendLine(item.ToString());
                        break;
                    case "back":
                        if (deck.Count > 0) item = deck[max];
                        sb.AppendLine(item.ToString());
                        break;
                }
            }

            Console.WriteLine(sb);
        }
    }
}
