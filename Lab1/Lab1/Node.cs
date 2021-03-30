using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
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
}
