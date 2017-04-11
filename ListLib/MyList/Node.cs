using System;
using System.Text;

namespace ListLib
{
    internal class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }
        public Node(T Value, Node<T> Next)
        {
            this.Value = Value;
            this.Next = Next;
        }
    }
}
