using System;
using System.Collections.Generic;

namespace PR_Lab2
{
    static public class AddUnique
    {
        static public void Try_add(List<int> list, int element, string thread)
        {
            lock (list)
            {
                int idx = list.IndexOf(element);
                if (idx >= 0)
                {
                    Console.WriteLine("F " + element + " " + thread);
                    return;

                }
                list.Add(element);
                Console.WriteLine("T " + element + " " + thread);
                return;

            }
        }
        static public void Add_some(List<int> list, string t)
        {
            for (int i = 0; i < 1000; i++)
                Try_add(list, i, t);
        }
    }
}
