using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace DoSomething
{
    class QuickSort
    {
        public void Demo()
        {

            List<int> list = new List<int>() { 12, 5, 34, 22, 9, 99, 51 };
            List<int> newList = Sort(list);

            foreach(var item in newList)
            {
                WriteLine(item);
            }
        }

        public static List<int> Sort(List<int> list)
        {
            int pivot = 0;

            if (list.Count < 2)
                return list;

            if (list.Count % 2 == 0)
            {
                pivot = list[list.Count / 2];
                list.RemoveAt(list.Count / 2);
            }
            else
            {
                pivot = list[(list.Count - 1) / 2];
                list.RemoveAt((list.Count - 1) / 2);
            }

            List<int> biglist = new List<int>();
            List<int> smalllist = new List<int>();
            List<int> newlist = new List<int>();

            foreach (var item in list)
            {
                if (item > pivot)
                {
                    biglist.Add(item);
                }
                else
                {
                    smalllist.Add(item);
                }
            }

            newlist.AddRange(Sort(smalllist));
            newlist.Add(pivot);
            newlist.AddRange(Sort(biglist));

            return newlist;
        }
    }
}
