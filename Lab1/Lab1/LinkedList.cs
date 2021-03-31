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

        public void DeleteDuplicates()
        {
            Node new_node = head;
            Node nnode;

            while(new_node.Next != null)
            {
                if(new_node.Data == new_node.Next.Data)
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

        public Node Read()
        {
            Node new_head = new Node();
            Node temp_node;
            Console.WriteLine("Enter the number of elements");
            int l = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[l];
            for(int i = 0; i < l; i++)
            {
                Console.WriteLine($"Enter {i + 1} element:");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(arr);
            Array.Reverse(arr);
            for(int i = 0; i < l; i++)
            {
                temp_node = new Node(arr[i]);
                temp_node.Next = new_head.Next;
                new_head.Next = temp_node;
            }
            return new_head.Next;
        }


        static void Main(string[] args)
        {
            LinkedList llist1 = new LinkedList();
            LinkedList llist2 = new LinkedList();
            LinkedList llist3 = new LinkedList();

            
            llist1.AddNodeToEnd(new Node(1));
            llist1.AddNodeToEnd(new Node(2));
            llist1.AddNodeToEnd(new Node(3));
            llist1.AddNodeToEnd(new Node(4));
            llist1.AddNodeToEnd(new Node(5));


            llist3.head = llist3.Read();
            Console.WriteLine("-------------------");
            llist3.PrintList();
        }
    }
}
