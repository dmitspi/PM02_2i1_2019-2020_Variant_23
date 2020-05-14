using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            // Создадим связный список
            LinkedList<string> l = new LinkedList<string>();
            // Добавим несколько элементов
                l.AddFirst("Apple");
                l.AddFirst("Banana");
            l.AddFirst("Pear");
                l.AddFirst("Orange");
                l.AddFirst(“Peach”);
            // Элементы в прямом порядке
            LinkedListNode<string> Node;
                Console.WriteLine(“Direct Order: “);
            for (Node = l.First; Node != null; Node = Node.Next)                 
                Console.Write(Node.Value + "\t");
            Console.WriteLine();
            // Элементы в обратном порядке
            Console.WriteLine(“Reverse order: “);
            for (Node = l.Last; Node != null; Node = Node.Previous)                 
                Console.Write(Node.Value + "\t");
            Console.ReadLine();
        }
    }
}
