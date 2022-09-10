using System;

namespace noddy
{
    internal class Node
    {
        public int Number { get; }
        public Node Next { get; set; }

      
        public Node(Node node, int number)
        {
            Number = number;
            Next = node;
        }

        
    }
    class LinkedList
    {      
        static public Node Pridat(Node node, int number)
        {
            while (node.Next != null)
            {
                node = node.Next;
            }

            Node node1 = new Node(null, number);
            node.Next = node1;

            return node1;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var b = new Node(null, 1);
            var a = new Node(b, 1);
            var c = LinkedList.Pridat(b, 8);

        }
    }
}
