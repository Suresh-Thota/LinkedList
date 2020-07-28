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
            //-------------------------------------------------------------------
            int data1, c;
            Console.WriteLine("select a node");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a new node to insert before " + c + " ");
            data1 = Convert.ToInt32(Console.ReadLine());
            list.InsertBefore(data1, c);

            //----------------------------------------------------------------------
            int data2, d;
            Console.WriteLine("enter the location");
            d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" enter a new node to insert at " + d);
            data2 = Convert.ToInt32(Console.ReadLine());
            list.InsertAtPosition(data2, d);
            //---------------------------------------------------------------------
            list.DeleteFirstNode();
            //----------------------------------------------------------------
            list.DeleteLastode();
            //---------------------------------------------------------------------
            int e;
            Console.WriteLine("enter a node that you want to delete");
            e = Convert.ToInt32(Console.ReadLine());
            list.deleteNode(e);
            //--------------------------------------------------------------------
            list.ReverseList();
            //-------------------------------------------------------------------
            list.BubbleSort();
        }
    }
}
