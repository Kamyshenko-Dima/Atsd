using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab1
{
    class LinkedList<T>
    {
        public Node<T> head;

        public void PrintList()
        {
            Node<T> n = head;
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
            Node<T> temp_node = head;
            while(temp_node != null)
            {
                l++;
                temp_node = temp_node.Next;
            }
            return l;
        }
        public int FindData(T data)
        {
            int count = 0;
            Node<T> temp_node = head;
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

        public void AddDataToFront(T data)
        {
            Node<T> new_node = new Node<T>(data);
            new_node.Next = head;
            head = new_node;
        }
        public void AddDataAfter(Node<T> prev_node, T data)
        {
            if(head == null)
            {
                head = new Node<T>(data);
                return;
            }
            Node<T> new_node = new Node<T>(data);
            new_node.Next = prev_node.Next;
            prev_node.Next = new_node;
        }
        public void DeleteData(T data)
        {
            Node<T> temp_node = head;
            Node<T> prev_node = null;

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

        public void AddNodeToEnd(Node<T> new_node)
        {
            if(head == null)
            {
                head = new_node;
            }
            else
            {
                Node<T> temp_node = head;
                while(temp_node.Next != null)
                {
                    temp_node = temp_node.Next;
                }
                temp_node.Next = new_node;
            }
        }

      //  public Node OrderedMerge(Node head1, Node head2)
      //  {
      //      /* a dummy first node to 
      //hang the result on */
      //      Node new_node = new Node();
      //      Node temp_node = new_node;
      //      /* tail points to the 
      //      last result node */

      //      while (true)
      //      {

      //          /* if either list runs out, 
      //          use the other list */
      //          if (head1 == null)
      //          {
      //              temp_node.Next = head2;
      //              break;
      //          }
      //          if (head2 == null)
      //          {
      //              temp_node.Next = head1;
      //              break;
      //          }

      //          /* Compare the data of the two 
      //          lists whichever lists' data is 
      //          smaller, append it into tail and 
      //          advance the head to the next Node 
      //          */
      //          if (head1.Data <= head2.Data)
      //          {
      //              temp_node.Next = head1;
      //              head1 = head1.Next;
      //          }
      //          else
      //          {
      //              temp_node.Next = head2;
      //              head2 = head2.Next;
      //          }

      //          /* Advance the tail */
      //          temp_node = temp_node.Next;
      //      }
      //      return new_node.Next;

      //  }
        public void DeleteDuplicates()
        {
            Node<T> new_node = head;
            Node<T> nnode;

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
            
        public Node<T> Separate(int pos)
        {
            Node<T> new_head = new Node<T>();
            Node<T> temp_node = head;
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

        //int SumEvenNumbers()
        //{ 
        //    int sum = 0;
        //    Node<int> temp_node = head;

        //    while (temp_node != null)
        //    {
        //        //if (temp_node.Data % 2 == 0) 
        //        //{
        //        //    sum += temp_node.Data;
        //        //}
                
        //        temp_node = temp_node.Next;
        //    }
        //    return sum;
        //}
        public Node<int> Read()
        {
            Node<int> new_head = new Node<int>();
            Node<int> temp_node;
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
                temp_node = new Node<int>(arr[i]);
                temp_node.Next = new_head.Next;
                new_head.Next = temp_node;
            }
            return new_head.Next;
        }



    }
}
