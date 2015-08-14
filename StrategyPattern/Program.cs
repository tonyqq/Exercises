using System;
using System.Collections.Generic;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new SortedList(new List<int> { 1, 4, 2, 6, 7, 3 }, new QuickSortStrategy());
            //var context = new SortedList(new List<int> { 1, 4, 2, 6, 7, 3 }, new MergeSortStrategy());
            //var context = new SortedList(new List<int> { 1, 4, 2, 6, 7, 3 }, new HeapSortStrategy());

            context.Sort();

            Console.ReadKey();
        }

        class SortedList
        {
            private List<int> _list;
            private SortingStrategy _sortingStrategy;

            public SortedList(List<int> list, SortingStrategy sortingStrategy)
            {
                if (sortingStrategy == null || list == null)
                {
                    throw new ArgumentNullException();
                }

                _list = list;
                _sortingStrategy = sortingStrategy;
            }

            public void Sort()
            {
                _sortingStrategy.Sort(_list);

                foreach (var item in _list)
                {
                    Console.Write(item + " ");
                }
            }
        }

        abstract class SortingStrategy
        {
            public abstract void Sort(List<int> list);
        }

        class QuickSortStrategy : SortingStrategy
        {
            public override void Sort(List<int> list)
            {
                list.Sort();
            }
        }

        class MergeSortStrategy : SortingStrategy
        {
            public override void Sort(List<int> list)
            {
                // TODO: Implement this later when in good mood
                Console.WriteLine("MergeSort not implemented yet");
            }
        }

        class HeapSortStrategy : SortingStrategy
        {
            public override void Sort(List<int> list)
            {
                // TODO: Implement this later when in good mood
                Console.WriteLine("HeapSort not implemented yet");
            }
        }
    }
}
