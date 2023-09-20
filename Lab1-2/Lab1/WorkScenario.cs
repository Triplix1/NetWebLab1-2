using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class WorkScenario
    {
        public MyLinkedList<int> MyLinkedList { get; set; }

        public WorkScenario(MyLinkedList<int> list)
        {
            MyLinkedList = list;
        }

        public void AddFirst()
        {
            for (int i = 0; i < 10; i++)
            {
                MyLinkedList.AddFirst(i);
            }

            Print(nameof(AddFirst));
        }

        public void Remove()
        {
            for (int i = 0; i < 10; i++)
            {
                MyLinkedList.Remove(i);
            }

            Print(nameof(Remove));
        }

        public void Add()
        {
            for (int i = 0; i < 10; i++)
            {
                MyLinkedList.Add(i);
            }

            Print(nameof(Add));
        }

        public void Clear()
        {
            MyLinkedList.Clear();

            Print(nameof(Clear));
        }

        public void CopyTo()
        {
            Console.WriteLine("CopyTo:");
            var arr = new int[10];
            MyLinkedList.CopyTo(arr, 0);

            arr.Foreach(Console.WriteLine);
        }

        private void Print(string functionName)
        {
            Console.WriteLine($"\nMyLinkedList ({functionName}):\n");
            MyLinkedList.Foreach(Console.WriteLine);
        }
    }
}
