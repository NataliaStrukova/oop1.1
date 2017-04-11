using System;
using System.Text;

namespace ListLib
{
    public interface IList<T> 
    {
        void Add(T value);
        void Clear();
        bool Contains(T value);
        int IndexOf(T value);
        void Insert(int index, T value);
        void Remove(T value);
        void RemoveAt(int index);
        IList<T> subList(int fromIndex, int toIndex);

        int Count { get; }
        T this[int index] { get; set; }

    }
}


