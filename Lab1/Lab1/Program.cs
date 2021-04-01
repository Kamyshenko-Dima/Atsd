using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList llist1 = new LinkedList();
            LinkedList llist2 = new LinkedList();
            LinkedList llist3 = new LinkedList();


            llist1.AddNodeToEnd(new Node(1));
            llist1.AddNodeToEnd(new Node(2));
            llist1.AddNodeToEnd(new Node(4));

            
            

            llist1.PrintList();
            Console.WriteLine("--------------");
            llist1.DeleteDuplicates();
            llist1.PrintList();

            //llist3.head = llist3.Read();
            //Console.WriteLine("----------------");
            //llist3.PrintList();
            //Console.WriteLine("----------------");
            //int x = llist3.SumEvenNumbers();
            //Console.WriteLine(x);
        }
    }
}
