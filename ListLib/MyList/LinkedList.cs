using System;
using System.Text;

namespace ListLib
{
    public class LinkedList<T> : IList<T>
    {
        private Node<T> first;
        private Node<T> last;
        private int count;

        public int Count
        {
            get { return count; }
        }

        public T this[int index]
        {
            get
            {
                int i = 0;
                Node<T> tmp = first;
                while (i++ < index)
                    tmp = tmp.Next;
                return tmp.Value;
            }

            set
            {
                int i = 0;
                Node<T> tmp = first;
                while (i++ < index)
                    tmp = tmp.Next;
                tmp.Value = value;
            }
        }


        public LinkedList()
        {
            count = 0;
            first = null;
            last = null;
        }


        public void Add(T value)
        {
            if (count == 0)
            {
                last = new Node<T>(value, null);
                first = last;
            }
            else
            {
                last.Next = new Node<T>(value, null);
                last = last.Next;
            }
            count++;
        }

        public void Clear()
        {
            count = 0;
            first = null;
            last = null;
        }
        public bool Contains(T val)
        {
            Node<T> tmp = first;
            while (tmp != null)
                if (val.Equals(tmp.Value))
                    return true;
                else
                    tmp = tmp.Next;
            return false;
        }

        public int IndexOf(T value)
        {
            Node<T> tmp = first;
            int index = 0;
            while (tmp != null && !value.Equals(tmp.Value))
            {
                index++;
                tmp = tmp.Next;
            }
            if (tmp == null)
                return -1;
            return index;
        }
        public void Insert(int index, T value)
        {
            if (index < 0 || index > Count)
                throw new ListException("Invalid index value");
            Node<T> tmp = first;
            if (index == 0)
                first = new Node<T>(value, tmp);
            else
                if (index == Count)
                {
                    last.Next = new Node<T>(value, null);
                    last = last.Next;
                }
            else
            {
                int i = 0;
                while (i++ < index - 1)
                    tmp = tmp.Next;
                Node<T> newNode = new Node<T>(value, tmp.Next);
                tmp.Next = newNode;
            }
            count++;
        }

        public void Remove(T value)
        {
            if (value.Equals(first.Value))
                first = first.Next;
            else
            {
                Node<T> tmp = first;
                while (!tmp.Next.Value.Equals(value) && tmp.Next != null)
                    tmp = tmp.Next;
                if (tmp.Next != null)
                    tmp.Next = tmp.Next.Next;
            }
            count--;

        }
        public void RemoveAt(int index)
        {
            if (index < 0 || index >= Count)
                throw new ListException("Invalid index value");
            if (index == 0)
                first = first.Next;
            else
            {
                Node<T> tmp = first;
                int i = 0;
                while (i < index - 1)
                {
                    i++;
                    tmp = tmp.Next;
                }
                tmp.Next = tmp.Next.Next;
            }
            count--;
        }

        public IList<T> subList(int fromIndex, int toIndex)
        {
            if (fromIndex < 0 || toIndex > Count || fromIndex > toIndex)
                throw new ListException("Invalid index value");
            IList<T> result = new LinkedList<T>();
            Node<T> tmp = first;
            int i = 0;
            while (i < fromIndex)
            {
                i++;
                tmp = tmp.Next;
            }
            while (i <= toIndex)
            {
                result.Add(tmp.Value);
                i++;
                tmp = tmp.Next;
            }

            return result;
        }

        public T[] ToArray()
        {
            T[] arr = new T[Count];
            Node<T> tmp = first;
            for (int i = 0; i < Count; i++)
            {
                arr[i] = tmp.Value;
                tmp = tmp.Next;
            }
            return arr;
        }


    }
}
