//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace DataStructure
//{
//    class LinkedList
//    {
//        Node head;
//        //2
//        //public void Add(int data)
//        //{
//        //    head = new Node(data);
//        //    Node p = head;
//        //    while (p != null)
//        //    {
//        //        Console.Write("{0}->", p.data);
//        //        p = p.next;
//        //    }
//        //}


//        //3
//        public void AddStart(int data)
//        {
//            Node startnode = new Node(data);
//            //startnode.data = data;
//            startnode.next = head;
//            head = startnode;
//        }

//        public void AddEnd(int data)
//        {
//            //Create a new node  
//            Node node = new Node(data);
//            //Checks if the list is empty  
//            if (head == null)
//            {
//                head = node;
//            }
//            else
//            {
//               Node tempnode = head;
//                while (tempnode.next != null)
//                {
//                    tempnode = tempnode.next;
//                }
//                tempnode.next = node;
//            }

//        }
//        public void InsertBetween(int data, int position)
//        {
//            Node newnode = new Node(data);
//            newnode.data = data;
//            newnode.next = null;
//            if (position < 1)
//            {
//                Console.ForegroundColor = ConsoleColor.Red;
//                Console.WriteLine("Position Should be greater than one");
//                Console.ResetColor();
//            }
//            else if (position == 1)
//            {
//                newnode.next = head;
//                head = newnode;
//            }
//            else
//            {
//                Node tempnode = new Node(data);
//                tempnode = head;
//                while (position > 2)
//                {
//                    tempnode = tempnode.next;
//                    position--;
//                }
//                newnode.next = tempnode.next;
//                tempnode.next = newnode;

//            }

//        }

//        public void Delete()
//        {
//            Node tempnode = head;
//            if (head != null)
//            {
//                tempnode = head;
//                head = head.next;
//                tempnode = null;
//            }

//        }
//        //display method
//        public void Display()
//        {
//            if (head == null)
//                Console.WriteLine("The list is empty.");
//            else
//            {
//                Console.ForegroundColor = ConsoleColor.Red;
//                Console.WriteLine("List Contains: ");
//                Console.ResetColor();
//                Node tempnode = head;
//                while (tempnode != null)
//                {
//                    Console.Write(tempnode.data + " ");
//                    tempnode = tempnode.next;
//                }
//            }
//            Console.WriteLine("\n");
//        }

//    }
//}
