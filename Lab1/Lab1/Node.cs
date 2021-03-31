using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Node <T>
    {
        public T Data;
        public Node<T> Next;

        //constructor
        public Node()
        {
            
            Next = null;
        }
        public Node(T d)
        {
            Data = d;
            Next = null;
        }
    }
}
