using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> llist1 = new LinkedList<int>();
            LinkedList<int> llist2 = new LinkedList<int>();
            LinkedList<string> llist3 = new LinkedList<string>();


            llist1.AddNodeToEnd(new Node<int>(1));
            llist1.AddNodeToEnd(new Node<int>(2));

            llist2.head = llist2.Read();
            

            llist1.PrintList();
            Console.WriteLine("--------------");
            llist2.PrintList();

            //llist3.head = llist3.Read();
            //Console.WriteLine("----------------");
            //llist3.PrintList();
            //Console.WriteLine("----------------");
            //int x = llist3.SumEvenNumbers();
            //Console.WriteLine(x);
        }
    }
}
