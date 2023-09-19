using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class MyLinkedListEventArgs<T> : EventArgs
    {
        public T item;
        public MyLinkedListEventArgs(T item) : base()
        {
            this.item = item;
        }
    }
}
