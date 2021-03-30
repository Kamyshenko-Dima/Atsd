using System;

namespace Lab1
{
    class LinkedList
    {
        Node head;
        

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
        public int FindData(int data)
        {
            int count = 0;
            Node temp_node = head;
            while(temp_node != null)
            {
                count++;
                if(temp_node.Data == data)
                {
                    return count;
                }
                temp_node = temp_node.Next;
            }
            return -10000;
        }

        public void AddDataToFront(int data)
        {
            Node new_node = new Node(data);
            new_node.Next = head;
            head = new_node;
        }
        public void AddDataAfter(Node prev_node, int data)
        {
            if(head == null)
            {
                head = new Node(data);
                return;
            }
            Node new_node = new Node(data);
            new_node.Next = prev_node.Next;
            prev_node.Next = new_node;
        }
        static void Main(string[] args)
        {
            LinkedList llist = new LinkedList();
            llist.head = new Node(1);
            Node second = new Node(2);
            Node third = new Node(4);

            llist.head.Next = second;
            second.Next = third;

            llist.PrintList();

            llist.AddDataAfter(third, 3);

            llist.PrintList();
        }
    }
}
