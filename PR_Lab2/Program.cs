using System;
using System.Collections.Generic;
using System.Threading;
/* Wielowątkowe dodawanie do struktury zawartej w dll */
namespace PR_Lab2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
            Thread t1 = new Thread(() => AddUnique.Add_some(list, "t1"));
            Thread t2 = new Thread(() => AddUnique.Add_some(list, "t2"));
            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();
        }
    }
}
