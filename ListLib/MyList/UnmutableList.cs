using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListLib
{
    public class UnmutableList<T> : IList<T>
    {
        private T[] array;
        private int count;
        public int Count
        {
            get { return count; }
        }
        public T this[int index]
        {
            get { return array[index]; }
            set { throw new ListException("Change of list is not available"); }
        }


        public UnmutableList(IList<T> list)
        {
            count = list.Count;
            array = new T[count];
            for (int i = 0; i < count; i++)
                array[i] = list[i];
        }

        public void Add(T value)
        {
            throw new ListException("Change of list is not available");
        }

        public void Clear()
        {
            throw new ListException("Change of list is not available");
        }

        public bool Contains(T value)
        {
            for (int i = 0; i < count; i++)
                if (array[i].Equals(value))
                    return true;
            return false;
        }

        public int IndexOf(T value)
        {
            int i = 0;
            while (!value.Equals(array[i]))
                i++;
            return i;
        }

        public void Insert(int index, T value)
        {
            throw new ListException("Change of list is not available");
        }

        public void Remove(T value)
        {
            throw new ListException("Change of list is not available");
        }

        public void RemoveAt(int index)
        {
            throw new ListException("Change of list is not available");
        }

        public IList<T> subList(int fromIndex, int toIndex)
        {
            if (fromIndex < 0 || toIndex > Count || fromIndex > toIndex)
                throw new ListException("Invalid index value");
            ArrayList<T> result = new ArrayList<T>();
            for (int i = fromIndex; i <= toIndex; i++)
                result.Add(array[i]);
            return result;
        }
    }
}
