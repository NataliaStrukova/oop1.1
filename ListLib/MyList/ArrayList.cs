using System;
using System.Text;

namespace ListLib
{
    public class ArrayList<T> : IList<T>
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
            set { array[index] = value; }
        }


        public ArrayList()
        {
            count = 0;
            array = new T[count];
        }

        public void Add(T value)
        {
            Array.Resize<T>(ref array, count+1);
            array[count++] = value;
        }

        public void Clear()
        {
            count = 0;
            array = new T[count];
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
            while (i < Count && !value.Equals(array[i]))
                i++;
            if (i == Count)
                return -1;
            return i;
        }

        public void Insert(int index, T value)
        {
            if (index < 0 || index > Count)
                throw new ListException("Invalid index value");
            T[] newArray = new T[count + 1];
            for (int i = 0; i < index; i++)
                newArray[i] = array[i];
            newArray[index] = value;
            Array.Copy(array, index, newArray, index+1, count - index);
            array = newArray;
            count++;
        }

        public void Remove(T value)
        {
            T[] newArray = new T[count-1];
            int i = 0;
            while (!value.Equals(array[i]))
            {
                newArray[i] = array[i];
                i++;
            }
            Array.Copy(array, i+1, newArray, i, count - i-1);
            array = newArray;
            count--;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= Count)
                throw new ListException("Invalid index value");
            while (index < count-1)
                array[index] = array[++index];
            Array.Resize<T>(ref array, --count);
        }

        public IList<T> subList(int fromIndex, int toIndex)
        {
            if (fromIndex < 0 || toIndex > Count || fromIndex > toIndex)
                throw new ListException("Invalid index value");
            ArrayList<T> result = new ArrayList<T>();
            for (int i = fromIndex; i<= toIndex; i++)
                result.Add(array[i]);
            return result;
        }

    }
}
