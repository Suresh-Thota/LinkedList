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
        public void InsertBefore(int data,int x)
        {
            Node temp;
            if(start == null)
            {
                Console.WriteLine("list is empty");
                return;
            }
            // if x is in first node new node will be inserted  before first node 
            if(start.info == x)
            {
                temp = new Node(data);
                temp.link = start;
                start = temp;
                return;
            }
            Node p = start;
            while(p.link != null)
            {
                if(p.link.info == x)
                {
                    break;
                }
                p = p.link;
            }
            if(p.link == null)
            {
                Console.WriteLine(x + " is not present in list");
            }
            else
            {
                temp = new Node(data);
                temp.link = p.link;
                p.link = temp;
            }
        }
        public void InsertAtPosition(int data , int x)
        {
            Node temp;
            Node p = start;
            if(x == 1)
            {
                temp = new Node(data);
                temp.link = start.link;
                start.link = temp;
                return;
            }
            for(int i = 1; i < x-1 && p != null; i++)
            {
                p = p.link; 
            }
            if(p == null)
            {
                Console.WriteLine(x + " is not present in the list");
            }
            else
            {
                temp = new Node(data);
                temp.link = p.link;
                p.link = temp;
            }
        }
        public void DeleteFirstNode()
        {
            if (start == null)
                return;
            start = start.link;
        }
        public void DeleteLastode()
        {
            if (start == null)
                return;
            if(start.link == null)
            {
                start = null;
                return;
            }
            Node p = start;
            while (p.link.link != null)
                p = p.link;
            p.link = null;

        }
        public void deleteNode(int x)
        {
            if(start == null)
            {
                Console.WriteLine(" list is empty");
                return;
            }
            if(start.info == x)
            {
                start = start.link;
                return;
            }
            Node p = start;
             while(p.link != null)
            {
                if(p.link.info == x)
                {
                    break;
                }
                p = p.link;
            }
             if(p == null)
            {
                Console.WriteLine(" given element " + x + " is not present in list ");
            }
            else
            {
                p.link = p.link.link;
            }
            {

            }
        }
        public void ReverseList()
        {
            Node prev, p, next;
            prev = null;
            p = start;
            while (p != null)
            {
                next = p.link;
                p.link = prev;
                prev = p;
                p = next;
            }
            start = prev;
        }
        public void BubbleSort()
        {
            Node p, q, end;
            for (end = null; end !=  start.link;end = p)
            {
                for(p = start;p.link!=end;p = p.link)
                {
                    q = p.link;
                    if (p.info > q.info)
                    {
                        int temp = p.info;
                        p.info = q.info;
                        q.info = temp;
                    }
                }
            }
             
        }
        public SingleLinkedList Merge1(SingleLinkedList list)
        {
            SingleLinkedList mergeList = new SingleLinkedList();
            mergeList.start = Merge1(start, list.start);
            return mergeList;
        }
        private Node Merge1(Node p,Node q)
        {
            Node startM;
            if(p.info <= p.info)
            {
                startM = new Node(p.info);
                p = p.link;
            }
            else
            {
                startM = new Node(q.info);
                q = q.link;
            }
            Node pm = startM;

            while(p != null && q != null)
            {
                if (p.info < q.info)
                {
                    pm.link = new Node(p.info);
                    p = p.link;
                }
                else
                {
                    pm.link = new Node(q.info);
                    q = q.link;
                }

            }

            while (p != null)
            {
                pm.link = new Node(p.info);
                p = p.link;
                pm = pm.link;
            }
            while (q != null)
            {
                pm.link = new Node(q.info);
                q = q.link;
                pm = pm.link;
            }
            return startM;
        }

        public SingleLinkedList Merge2(SingleLinkedList list)
        {
            SingleLinkedList mergelist = new SingleLinkedList();
            mergelist.start = Merge2(start, list.start);
            return mergelist;
        }
        private Node Merge2(Node p1,Node p2)
        {
            Node startM;
            if(p1.info < p2.info)
            {
                startM = p1;
                p1 = p1.link;
            }
            else
            {
                startM = p2;
                p2 = p2.link;
            }
            Node pm = startM;
            while (p1 != null && p2 != null)
            {
                if (p1.info <= p2.info)
                {
                    pm.link = p1;
                    pm = pm.link;
                    p1 = p1.link;
                }
                else
                {
                    pm.link = p2;
                    pm = pm.link;
                    p2 = p2.link;
                }
            }
            if(p1 == null)
            {
                pm.link = p2;
            }
            else
            {
                pm.link = p1;
            }
            return startM;
        }
        public void MergeSort()
        {
            start = MergeSortRec(start);
        }
        private Node MergeSortRec(Node listStart)
        {
            if (listStart == null || listStart.link == null)
            {
                return listStart;
            }
            Node start1 = listStart;
            Node start2 = DivideList(listStart);
            start1 = MergeSortRec(start1);
            start2 = MergeSortRec(start2);
            Node startM = Merge2(start1, start2);
            return startM;
        }
        private Node DivideList(Node p)
        {
            Node q = p.link.link;
            while (q != null && q.link != null)
            {
                p = p.link;
                q = p.link.link;
            }
            Node start2 = p.link;
            p.link = null;
            return start2;
        }
        public bool HasCycle()
        {
            if (FindCycle() == null)
            {
                return false;
            }
            else
                return true;
        }
        private Node FindCycle()
        {
            if (start == null || start.link == null)
                return null;
            Node slowR = start, fastR = start;
            while(fastR != null && fastR.link != null)
            {
                slowR = slowR.link;
                fastR = fastR.link.link;
                if (slowR == fastR)
                {
                    return slowR;
                }
            }
            return null;
        }
        public void RemoveCycle()
        {
            Node c = FindCycle();
            if (c == null)
                return;
            Console.WriteLine("Node at which the cycle was detected is :" + c.info);
            Node p = c, q = c;
            int lenCycle = 0;
            do
            {
                lenCycle++;
                q = q.link;
            } while (q != p);
            Console.WriteLine("length of Cycle is :" + lenCycle);
            int lenRemList = 0;
            p = start;
            while (p != q)
            {
                lenRemList++;
                p = p.link;
                q = q.link;
            }
            Console.WriteLine("number of Nodes not included in the Cycle are :" + lenRemList);

            int lengthOfList = lenCycle + lenRemList;
            Console.WriteLine("Length of the List :" + lengthOfList);
            p = start;
            for(int i = 1; i <= lengthOfList - 1; i++)
            {
                p = p.link;
            }
            p.link = null;      
        }
        public void InsertCycle(int x)
        {
            if (start == null)
                return;
            Node p = start, px = null, prev = null;
            while (p != null)
            {
                if (p.info == x)
                    px = p;
                prev = p;
                p = p.link;
            }
            if (px != null)
            {
                prev.link = px;
            }
            else
            {
                Console.WriteLine(x + " not present in the list");
            }
        }

    }
}
