namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myList = new MyLinkedList<int>();
            for (int i = 0; i < 10; i++)
            {
                myList.Add(i);
            }

            foreach (int i in myList)
            {
                Console.WriteLine(i);
            }
        }
    }
}