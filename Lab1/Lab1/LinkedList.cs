using System;

namespace Lab1
{
    class LinkedList
    {
        class Node
        {
            public int Data;
            public Node Next;

            //constructor
            public Node(int d)
            {
                Data = d;
                Next = null;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
