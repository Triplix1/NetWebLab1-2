using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public sealed class MyLinkedList<T> : ICollection<T>
    {
        public MyLinkedListNode<T>? Head { get; set; }
        public MyLinkedListNode<T>? Tail { get; set; }

        private int count;

        public MyLinkedList()
        {
            count = 0;
        }

        public MyLinkedList(IEnumerable<T> list)
        {
            if (list == null) 
                throw new ArgumentNullException("list can`t be null");

            foreach (var item in list)
            {
                Add(item);
            }
        }

        public int Count => count;

        public bool IsReadOnly => false;

        public void Add(T item)
        {
            if (count <= 0)
            {
                Head = new MyLinkedListNode<T>(item);
                Head.Next = Head;
                Head.Previous = Head;
                Tail = Head;
                     
            }
            else
            {
                var newNode = new MyLinkedListNode<T>(Head, Tail,item);
                Tail.Next = newNode;
                Tail = newNode;
                Head.Previous = Tail;
            }
            count++;
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
            count = 0;
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    public sealed class MyLinkedListNode<T>
    {
        public MyLinkedListNode<T>? Next { get; set; }
        public MyLinkedListNode<T>? Previous { get; set; }
        public T Value { get; set; }

        public MyLinkedListNode(T value)
        {
            Value = value;
            Next = Previous = null;
        }

        public MyLinkedListNode(MyLinkedListNode<T>? next, MyLinkedListNode<T>? previous, T value) : this(value)
        {
            Next = next;
            Previous = previous;
        }
    }
}
