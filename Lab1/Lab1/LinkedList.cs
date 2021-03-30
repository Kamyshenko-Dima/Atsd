using System;

namespace Lab1
{
    class LinkedList
    {
        Node head;
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

        public void PrintList()
        {
            Node n = head;
            while(n != null)
            {
                Console.Write(n.Data + " ");
                n = n.Next;
            }
            Console.WriteLine();
        }
        public int Length()
        {
            int l = 0;
            Node temp_node = head;
            while(temp_node != null)
            {
                l++;
                temp_node = temp_node.Next;
            }
            return l;
        }
        public int FindData(int item)
        {
            int count = 0;
            Node temp_node = head;
            while(temp_node != null)
            {
                count++;
                if(temp_node.Data == item)
                {
                    return count;
                }
                temp_node = temp_node.Next;
            }
            return -10000;
        }
        static void Main(string[] args)
        {
            LinkedList llist = new LinkedList();
            llist.head = new Node(1);
            Node second = new Node(2);
            Node third = new Node(3);

            llist.head.Next = second;
            second.Next = third;

            llist.PrintList();

            Console.WriteLine(llist.FindData(0));
        }
    }
}
