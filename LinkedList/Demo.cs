using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class Demo
    {
        static void Main(String[] arg)
        {
            SingleLinkedList list = new SingleLinkedList();

            list.CreateList();
            list.Display();
            list.CountNode();
            int x = 0;
            Console.WriteLine("Enter an element to search");
            x = Convert.ToInt32(Console.ReadLine());
            list.Search(x);
            list.ReferenceAtLastNode();
            list.ReferenceAtSecondLastNode();
            int y = 0;
            Console.WriteLine("Enter an element to get predecessor of that node");
            y = Convert.ToInt32(Console.ReadLine());
            list.predecessorOfGivenNode(y);
            int z = 0;
            Console.WriteLine("Enter an element to get node");
            z = Convert.ToInt32(Console.ReadLine());
            list.NodeAtParticularPosition(z);
            int a = 0;
            Console.WriteLine("enter an element ");
            a = Convert.ToInt32(Console.ReadLine());
            list.InsertAtBeginningToList(a);
            //------------------------------------------------------------------
            int data, b;
            Console.WriteLine("select a node");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a new node to insert after " + b + " ");
            data = Convert.ToInt32(Console.ReadLine());
            list.InsertAfter(data, b);
        }
    }
}
