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
        public void DeleteData(int data)
        {
            Node temp_node = head;
            Node prev_node = null;

            if (temp_node != null && temp_node.Data == data)
            {
                head = temp_node.Next;
                return;
            }

            while (temp_node != null && temp_node.Data != data)
            {
                prev_node = temp_node;
                temp_node = temp_node.Next;
            }

            if (temp_node == null)
            {
                return;
            }

            prev_node.Next = temp_node.Next;
        }

        public void AddNodeToEnd(Node new_node)
        {
            if(head == null)
            {
                head = new_node;
            }
            else
            {
                Node temp_node = head;
                while(temp_node.Next != null)
                {
                    temp_node = temp_node.Next;
                }
                temp_node.Next = new_node;
            }
        }

        //public LinkedList Merge(LinkedList llist2)
        //{
        //    LinkedList new_llist = new LinkedList();
            
        //}
        static void Main(string[] args)
        {
            LinkedList llist = new LinkedList();

            
            llist.AddNodeToEnd(new Node(1));
            llist.AddNodeToEnd(new Node(2));
            llist.AddNodeToEnd(new Node(4));
            llist.AddNodeToEnd(new Node(3));
            

            llist.PrintList();

            llist.DeleteData(4);

            llist.PrintList();
        }
    }
}
