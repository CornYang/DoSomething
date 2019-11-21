using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using static System.Console;

namespace DoSomething
{
    public class QuickSort
    {
        public void Demo()
        {

            List<int> lists = new List<int>() { 12, 5, 34, 22, 9, 99, 51 };
            List<int> newList = Sort(lists);

            foreach(var item in newList)
            {
                WriteLine(item);
            }
        }

        public static void Demo02()
        {
            Func<List<int>, List<int>> newList = (List<int> list) => Sort(list);

            List<int> lists = new List<int>() { 12, 5, 34, 22, 9, 99, 51 };

            foreach (var item in newList(lists))
            {
                Write(item + " ");
            }
            WriteLine();
        }

        public static void Demo03(List<int> lists)
        {
            Func<List<int>, List<int>> newList = (List<int> list) => Sort(list);

            foreach (var item in newList(lists))
            {
                Write(item + " ");
            }
            WriteLine();
        }

        public static void QuickSortDemo01(Action f)
        {
            var sw = new Stopwatch();
            sw.Reset();
            sw.Start();
            f();
            sw.Stop();
            WriteLine($"快速排序法 總共花了: {sw.ElapsedMilliseconds} 毫秒");
        }

        //public static void QuickSortDemo02(Action f, List<int> list)
        //{
        //    var sw = new Stopwatch();
        //    sw.Reset();
        //    sw.Start();
        //    f();
        //    sw.Stop();
        //    WriteLine($"快速排序法 總共花了: {sw.ElapsedMilliseconds} 毫秒");
        //}

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

        //public static List<T> ToQuickSort<T>(List<int> list)
        //{
        //    int pivot = 0;

        //    if (list.Count < 2)
        //        return list;

        //    if (list.Count % 2 == 0)
        //    {
        //        pivot = list[list.Count / 2];
        //        list.RemoveAt(list.Count / 2);
        //    }
        //    else
        //    {
        //        pivot = list[(list.Count - 1) / 2];
        //        list.RemoveAt((list.Count - 1) / 2);
        //    }

        //    List<int> biglist = new List<int>();
        //    List<int> smalllist = new List<int>();
        //    List<int> newlist = new List<int>();

        //    foreach (var item in list)
        //    {
        //        if (item > pivot)
        //        {
        //            biglist.Add(item);
        //        }
        //        else
        //        {
        //            smalllist.Add(item);
        //        }
        //    }

        //    newlist.AddRange(Sort(smalllist));
        //    newlist.Add(pivot);
        //    newlist.AddRange(Sort(biglist));

        //    return newlist;
        //}
    }
}
