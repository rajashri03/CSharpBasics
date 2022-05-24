//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace DataStructure
//{
//    //A Queue is a linear structure which follows a particular order in
//    //which the operations are performed.
//    //The order is First In First Out (FIFO).//LILO
//    //insertion--rear/tail--enqueue
//    //deletion--front/front---dequeue
//    //peek/front
//    class Queue_Ex
//    {
//        Node front;
//        Node rear;
//        public void Enqueue(int data)
//        {
//            Node newnode = new Node(data);
//            if(front==null)
//            {
//                rear = newnode;
//                front = rear;
//            }
//            else
//            {
//                rear.next = newnode;
//                rear = rear.next;
//            }
//        }
//        public void Display()
//        {
//            if (front == null)
//            {
//                Console.WriteLine("Queu is empty");
//            }
//            Node temp = front;
//            while (temp != null)
//            {
//                Console.Write("| " + temp.data + " |");
//                temp = temp.next;
//            }
//        }
//        public void Dequeue()
//        {
//            if (this.front == null)
//            {
//                Console.WriteLine("Queue is empty, deletion is not possible");
//                return;
//            }
//            Console.WriteLine("{0} is element dequeue ", this.front.data);
//            this.front = this.front.next;
//        }
//    }
//}
