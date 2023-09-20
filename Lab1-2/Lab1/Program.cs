using System.Threading.Channels;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myList = new MyLinkedList<int>();

            myList.AddedNode += (sender, args) => Console.WriteLine($"has been added value {args.item}");
            myList.RemovedNode += (sender, args) => Console.WriteLine($"has been removed value {args.item}");

            var scenario = new WorkScenario(myList);

            scenario.AddFirst();
            Console.WriteLine();

            scenario.Remove();
            Console.WriteLine();

            scenario.Add();
            Console.WriteLine();

            scenario.CopyTo();
            Console.WriteLine();

            scenario.Clear();
        }
    }
}