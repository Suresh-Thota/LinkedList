﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class Demo
    {
        static void Main(string[] args)
        {
            int choice, data, k, x;
            SingleLinkedList list = new SingleLinkedList();
            list.CreateList();

            while (true)
            {
                Console.WriteLine("1.Display List");
                Console.WriteLine("2.Count the number of nodes");
                Console.WriteLine("3.search for an element");
                Console.WriteLine("4.Insert in empty list");
                Console.WriteLine("5.Insert a node at the end of list ");
                Console.WriteLine("6.Insert a node after a specified node");
                Console.WriteLine("7.Insert a node before a specified node");
                Console.WriteLine("8.Insert a node at a given position");
                Console.WriteLine("9.Delete first node");
                Console.WriteLine("10.Delete last node");
                Console.WriteLine("11.Delete any node");
                Console.WriteLine("12.Reverse the last");
                Console.WriteLine("13.Bubble sort by exchanging data");
                Console.WriteLine("14.Merging with two lists");
                Console.WriteLine("15.Merge sort");
                Console.WriteLine("16.Insert cycle");
                Console.WriteLine("17.delete cycle");
                Console.WriteLine("18.Remove cycle");
                Console.WriteLine("19.Quit");
                Console.Write("Enter your choice:");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 19)
                    break;
                switch (choice)
                {
                    case 1:
                        list.Display();
                        break;
                    case 2:
                        list.CountNode();
                        break;
                    case 3:
                        Console.Write("Enter element to be searched");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.Search(data);
                        break;
                    case 4:
                        Console.WriteLine("Enter Element to be inserted");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtBeginningToList(data);
                        break;
                    case 5:
                        Console.WriteLine("Enter Element to be inserted");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtEnd(data); ;
                        break;
                    case 6:
                        Console.WriteLine("Enter Element to be inserted");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Element after which to be inserted:");
                        x = Convert.ToInt32(Console.ReadLine());
                        list.InsertAfter(data, x);
                        break;
                    case 7:
                        Console.WriteLine("Enter Element to be inserted");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Element before which to be inserted:");
                        x = Convert.ToInt32(Console.ReadLine());
                        list.InsertBefore(data, x);
                        break;
                    case 8:
                        Console.WriteLine("Enter Element to be inserted");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter position which to be inserted:");
                        k = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtPosition(data, k);
                        break;
                    case 9:
                        list.DeleteFirstNode();
                        break;
                    case 10:
                        list.DeleteLastode();
                        break;
                    case 11:
                        Console.WriteLine("Enter Element to be deleted:");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.deleteNode(data);
                        break;
                    case 12:
                        list.ReverseList();
                        break;
                    case 13:
                        list.BubbleSort();
                        break;
                    case 14:
                        // list.BubbleSortExLinks();
                        SingleLinkedList list1 = new SingleLinkedList();
                        SingleLinkedList list2 = new SingleLinkedList();

                        list1.CreateList();
                        list2.CreateList();

                        list1.BubbleSort();
                        list2.BubbleSort();

                        Console.WriteLine(" First List:");
                        list1.Display();
                        Console.WriteLine(" Second List");
                        list2.Display();

                        SingleLinkedList list3;
                        list3 = list1.Merge1(list2);
                        break;
                    case 15:
                        list.MergeSort();
                        break;
                    case 16:
                        Console.WriteLine("Enter element at which cycle has to be inserted  ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertCycle(data);
                        break;
                    case 17:
                        if (list.HasCycle())
                            Console.WriteLine("List has a cycle");
                        else
                            Console.WriteLine("List does not  have a cycle");
                        break;
                    case 18:
                        list.RemoveCycle();
                        break;
                    default:
                        Console.WriteLine("Wrong choice:");
                        break;



                }
                Console.WriteLine();


            }
            Console.WriteLine("Existing");
        }
    }

}
