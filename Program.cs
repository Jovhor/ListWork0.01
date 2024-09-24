using System;
using System.Collections.Generic;

namespace ListWork0._01
{
    class Program
    {
        /// <summary>
        /// Вывод элементов листа в консоль
        /// </summary>
        /// <param name="list"></param>
        static void MyListPrint(List<int> list)
        {
            Console.WriteLine($"Элементов в листе: {list.Count}");
            for (int i = 0; i < list.Count; i++) Console.WriteLine($"Элемент: {i} = {list[i]}");
            Console.WriteLine("-------------------------------------------------------------------");
        }

        /// <summary>
        /// Удаление элементов листа в заданным диапазоне
        /// </summary>
        /// <param name="list"></param>
        /// <param name="at"></param>
        /// <param name="to"></param>
        static void MyListRemoveAtTo(List<int> listy, int at, int to)
        {
            listy.RemoveAll(list => list > at && list < to);
        }

        /// <summary>
        /// Заполнение листа рандомными числами в заданном диапозоне
        /// </summary>
        /// <param name="list"></param>
        static void MyListRandGenerate(List<int> list, int a, int b)
        {
            Random rand = new Random();
            for (int i = 0; i < 100; i++) list.Add(rand.Next(a, b));
        }

        /// <summary>
        /// Сортировка элементов листа по возрастанию
        /// </summary>
        /// <param name="list"></param>
        /// <param name="at"></param>
        /// <param name="to"></param>
        static void MyListSorted(List<int> list)
        {
            list.Sort();
        }

        static void Main()
        {
            List<int> list = new List<int>();

            MyListRandGenerate(list, 0, 100);
            MyListPrint(list);

            Console.WriteLine("больше 25, но меньше 50");
            MyListRemoveAtTo(list, 25, 50);
            MyListPrint(list);

            Console.WriteLine();
            Console.WriteLine("проверим, получилось ли");
            MyListSorted(list);
            MyListPrint(list);

            Console.ReadKey();
        }
    }
}

