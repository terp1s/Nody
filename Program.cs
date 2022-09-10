using System;
using System.Collections.Generic;

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
        Node Zacatek { get; set; }
        Node Konec { get; set; }

        public Node Add2(Node node, int number)
        {
            while (node.Next != null)
            {
                node = node.Next;
            }
            Node node1 = new Node(null, number);
            node.Next = node1;
            

            return node1;
        }

        public void Add(int number)
        {
            if (Zacatek == null)
            {
                Zacatek = new Node(null, number);
                Konec = Zacatek;
            }
            else
            {
                Node node = new Node(null, number);
                Konec.Next = node;
                Konec = node;
            }

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var list2 = new LinkedList();
            var a = new Node(null, 1);
            var b = list2.Add2(a, 5);
            var c = list2.Add2(b, 6);
            var d = list2.Add2(c, 7);

            var list = new LinkedList();

            list.Add(5);
            list.Add(6);
            list.Add(7);







            Console.ReadKey();
        }
    }
}
