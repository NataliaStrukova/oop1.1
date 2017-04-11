using System;
using System.Text;

namespace ListLib
{
    public static class ListUtils
    {
        public delegate bool CheckDelegate<T>(T obj);
        public delegate IList<T> ListConstructorDelegate<T>();
        public delegate TO ConvertDelegate<TI, TO>(TI input);
        public delegate void ActionDelegate<T>(T obj);
        public delegate int CompareDelegate<T>(T x, T y);

        public static bool Exists<T>(IList<T> list, CheckDelegate<T> checkDelegate)
        {
            int i = 0;
            int count = list.Count;
            while (i < count && !checkDelegate(list[i]))
                i++; ;
            if (i >= count)
                return false;
            return true;
        }

        public static T Find<T>(IList<T> list, CheckDelegate<T> checkDelegate)
        {
            int i = 0;
            int count = list.Count;
            while (i < count && !checkDelegate(list[i])) 
                i++;
            if (i < count)
                return list[i];
            return default(T);
        }

        public static T FindLast<T>(IList<T> list, CheckDelegate<T> checkDelegate)
        {
            int i = list.Count - 1;
            while (i > -1 && !checkDelegate(list[i]))
                i--;
            if (i > -1)
                return list[i];
            return default(T);
        }

        public static int FindIndex<T>(IList<T> list, CheckDelegate<T> checkDelegate)
        {
            int i = 0;
            int count = list.Count;
            while (i< count && !checkDelegate(list[i]))
                i++;
            if (i < count)
                return i;
            return -1;
        }

        public static int FindLastIndex<T>(IList<T> list, CheckDelegate<T> checkDelegate)
        {
            int i = list.Count - 1;
            while (!checkDelegate(list[i]) && i-- > -1) ;
            if (i > -1)
                return i;
            return -1;
        }

        public static IList<T> FindAll<T>(IList<T> list, CheckDelegate<T> checkDelegate, ListConstructorDelegate<T> listConstructorDelegate)
        {
            IList<T> resultList = listConstructorDelegate();
            ForEach<T>(list, x =>
            {
                if (checkDelegate(x))
                {
                    resultList.Add(x);
                }
            });
            return resultList;
        }

        public static IList<TO> ConvertAll<TI, TO>(IList<TI> list, ConvertDelegate<TI, TO> convertDelegate,
            ListConstructorDelegate<TO> listConstructorDelegate)
        {
            IList<TO> resultList = listConstructorDelegate();
            int count = list.Count;
            for (int i = 0; i < count; i++)
                resultList.Add(convertDelegate(list[i]));
            return resultList;
        }

        public static void ForEach<T>(IList<T> list, ActionDelegate<T> actionDelegate)
        {
            int count = list.Count;
            for (int i = 0; i < count; i++)
                actionDelegate(list[i]);
        }

        public static void Sort<T>(IList<T> list, CompareDelegate<T> compareDelegate)
        {
            Qsort<T>(list, 0, list.Count - 1, compareDelegate);
        }


        private static int defaultCompareDelegate<T>(T x1, T x2)
            where T :IComparable<T>
        {
            return x1.CompareTo(x2);
        } 

        public static void Sort<T>(IList<T> list) 
            where T :IComparable<T>
        {
            Sort(list, defaultCompareDelegate);
        }

        public static bool CheckForAll<T>(IList<T> list, CheckDelegate<T> checkDelegate)
        {
            int count = list.Count;
            for (int i = 0; i<count; i++)
                if (!checkDelegate(list[i]))
                    return false;
            return true;
        }


        private static void Qsort<T>(IList<T> list, int l, int r, CompareDelegate<T> compareDelegate)
        {
            T tmp;
            T x = list[l];
            int i = l;
            int j = r;
            while (i <= j)
            {
                while (compareDelegate(list[i], x) < 0)
                    i++;
                while (compareDelegate(list[j], x) > 0)
                    j--;
                if (i <= j)
                {
                    tmp = list[i];
                    list[i] = list[j];
                    list[j] = tmp;
                    i++;
                    j--;
                }
            }
            if (i < r)
                Qsort(list, i, r, compareDelegate);

            if (l < j)
                Qsort(list, l, j, compareDelegate);
        }
    }
}
