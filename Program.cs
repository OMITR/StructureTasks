using System;

namespace StructureTasks
{
    public class Program
    {
        static void Main(string[] args)
        {
            var minions = new TwoWayLinkedList<Minion>();

            minions.Add(new Minion(1, "Johny Silverhand", 255, 3));
            minions.Add(new Minion(2, "Michael", 53, 1));

            Console.WriteLine("Comparator in the Modified Two-way Linked List:");

            Console.WriteLine(minions[0].CompareTo(minions[1]));
            Console.WriteLine(minions[1].CompareTo(minions[0]));
            Console.WriteLine(minions[0].CompareTo(minions[0]) + "\n");

            Stack stack = new Stack(3);

            Console.WriteLine("Array-based Stack:");

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            Console.WriteLine("Peek: " + stack.Peek());

            foreach (var item in stack)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nCount: " + stack.Count);

            int length = stack.Count;
            for (int i = 0; i < length; i++)
            {
                Console.Write(stack.Pop() + " ");
            }

            Console.WriteLine("\nCount: " + stack.Count);
        }
    }
}
