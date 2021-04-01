using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab1
{
    class LinkedList
    {
        public Node head;
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
                if(temp_node.Data.Equals(data))
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

            if (temp_node != null && temp_node.Data.Equals(data))
            {
                head = temp_node.Next;
                return;
            }

            while (temp_node != null && !temp_node.Data.Equals(data))
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

        public Node OrderedMerge(Node head1, Node head2)
        {
            Node new_node = new Node();
            Node temp_node = new_node;

            while (true)
            {

                if (head1 == null)
                {
                    temp_node.Next = head2;
                    break;
                }
                if (head2 == null)
                {
                    temp_node.Next = head1;
                    break;
                }

                if (head1.Data <= head2.Data)
                {
                    temp_node.Next = head1;
                    head1 = head1.Next;
                }
                else
                {
                    temp_node.Next = head2;
                    head2 = head2.Next;
                }
                temp_node = temp_node.Next;
            }
            return new_node.Next;

        }
        public void DeleteDuplicates()
        {
            Node new_node = head;
            Node nnode;

            while(new_node.Next != null)
            {
                if(new_node.Data.Equals(new_node.Next.Data))
                {
                    nnode = new_node.Next.Next;
                    new_node.Next = null;
                    new_node.Next = nnode;
                }
                else
                {
                    new_node = new_node.Next;
                }
            }
        }
            
        public Node Separate(int pos)
        {
            Node new_head = new Node();
            Node temp_node = head;
            int count = 0;
            while(temp_node != null)
            {
                count++;
                if(count == pos)
                {
                    new_head = temp_node.Next;
                    temp_node.Next = null;
                    break;
                }
                temp_node = temp_node.Next;
            }
            return new_head;
        }

        public int SumEvenNumbers()
        {
            int sum = 0;
            Node temp_node = head;

            while (temp_node != null)
            {
                if (temp_node.Data % 2 == 0)
                {
                    sum += temp_node.Data;
                }
                temp_node = temp_node.Next;
            }
            return sum;
        }

        public Node Read()
        {
            Node new_head = new Node();
            Node temp_node;
            Console.WriteLine("Enter the number of elements");
            int l = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[l];
            for (int i = 0; i < l; i++)
            {
                Console.WriteLine($"Enter {i + 1} element:");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(arr);
            Array.Reverse(arr);
            for (int i = 0; i < l; i++)
            {
                temp_node = new Node(arr[i]);
                temp_node.Next = new_head.Next;
                new_head.Next = temp_node;
            }
            return new_head.Next;
        }

        public void Reverse()
        {
            Node new_node = head;
            Node prev_node = null;
            Node next_node = null;

            while (new_node != null)
            {
                next_node = new_node.Next;
                new_node.Next = prev_node;
                prev_node = new_node;
                new_node = next_node;
            }
            head = prev_node;
        }


    }
}
