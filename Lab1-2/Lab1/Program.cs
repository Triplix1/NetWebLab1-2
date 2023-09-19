namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myList = new MyLinkedList<int>();   
            
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i < 10; i++)
            {
                myList.AddFirst(i);
            }

            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i < 10; i++)
            {
                myList.Remove(i);
            }

            foreach (int i in myList)
            {
                Console.WriteLine(i);
            }

            //var arr = new int[9];
            //arr[0] = -1;
            //myList.CopyTo(arr, 1);

            //for (int i = 0;i < arr.Length; i++)
            //    Console.WriteLine(arr[i]);
        }
    }
}