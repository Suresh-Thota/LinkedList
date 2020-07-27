using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class SingleLinkedList
    {
        private Node start;

        public SingleLinkedList()
        {
            start = null;
        }
        public void CreateList()
        {
            int i, n, data;
            Console.Write("Enter the number of nodes");

            n = Convert.ToInt32(Console.ReadLine());

            for( i = 0; i < n; i++)
            {
                Console.Write("enter the element to be inserted");
                data = Convert.ToInt32(Console.ReadLine());
                InsertAtEnd(data);
            }
        }
        public void InsertAtEnd(int data)
        {
            Node p;
            Node temp = new Node(data);
            if(start == null)
            {
                start = temp;
                return;
            }
            p = start;
            while(p.link != null)
            {
                p = p.link;
            }
            p.link = temp;
        }
        public void Display()
        {
            Node p;
            if(start == null)
            {
                Console.WriteLine("List is Empty");
                return;
            }
            Console.WriteLine("List is :  ");
            p = start;
            while(p != null)
            {
                Console.Write(p.info + "  ");
                p = p.link;
            }
            Console.WriteLine();
        }
        public void CountNode()
        {
            int n = 0;
            Node p = start;
            while(p != null)
            {
                p = p.link;
                n++;
            }
            Console.WriteLine("Number od Nodes are :" + n);
        }
        public void Search(int x)
        {
            int n = 1;
            Node p = start;
            while(p != null)
            {
                if(p.info == x)
                {
                    break;
                }
                p = p.link;
                n++;
            }
            if(p == null)
            {
                Console.WriteLine("Given element is not found");
            }
            else
            {
                Console.WriteLine("Element is found at " + n + " position");
            }
        }
        public void ReferenceAtLastNode()
        {
            Node p = start;
            while(p.link != null)
            {
                p = p.link;
            }
            Console.WriteLine("Reference at Last Node is : " + p.info);
        }
        public void ReferenceAtSecondLastNode()
        {
            Node p = start;
            while (p.link.link != null)
            {
                p = p.link;
            }
            Console.WriteLine("Reference at Second Last Node is : " + p.info);
        }
        public void predecessorOfGivenNode(int x)
        {
            Node p = start;
            while(p.link != null)
            {
                if(p.link.info == x)
                {
                    break;
                }
                p = p.link;
            }
            Console.WriteLine("predecessor of given node is : " + p.info);
        }
        public void NodeAtParticularPosition(int x)
        {
            Node p = start;
            for(int i = 1; i<x && p != null; i++)
            {
                p = p.link;
            }
            Console.WriteLine("Element at " + x + " position is : " + p.info);

        }
        public void InsertAtBeginningToList(int x)
        {
            Node temp = new Node(x);
            temp.link = start;
            start = temp;
        }
        public void InsertAfter(int data,int b)
        {
            Node p = start;
            while(p != null)
            {
                if(p.info == b)
                {
                    break;
                }
                p = p.link;
            }
            if(p == null)
            {
                Console.WriteLine(b + " is not present in the list");
            }
            else
            {
                Node temp = new Node(data);
                temp.link = p.link;
                p.link = temp;
            }
        }
    }
}
