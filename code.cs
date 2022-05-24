////using System;
////using System.Collections.Generic;
////using System.Text;

////namespace DataStructure
////{
////    class code
////    {
////        Node top;
////        public Stack_Ex()
////        {
////            this.top = null;
////        }
////        public void push(int data)
////        {
////            Node newnode = new Node(data);
////            newnode.next = this.top;
////            this.top = newnode;
////        }
////        public void display()
////        {
////            if (this.top == null)
////            {
////                Console.WriteLine("Stack is empty");
////            }
////            Node temp = this.top;
////            while (temp != null)
////            {
////                Console.WriteLine("| " + temp.data + " |");
////                temp = temp.next;
////            }
////        }
////        public void peek()

////        {
////            if (this.top == null)
////            {
////                Console.WriteLine("Stack is empty");
////            }
////            else
////            {
////                Console.WriteLine("top element is" + this.top.data);
////            }
////        }
////        public void POP()

////        {
////            if (this.top == null)
////            {
////                Console.WriteLine("Stack is empty");
////            }
////            else
////            {
////                Node temp = top;
////                top = top.next;
////            }
////        }

////    }
////}


//Node front;
//Node rear;


//public void Enqueu(int data)
//{
//    Node node = new Node(data);
//    if (this.front == null)
//    {
//        this.rear = node;
//        front = rear;

//    }
//    else
//    {
//        rear.next = node;
//        rear = rear.next;
//    }
//    Console.WriteLine("{0} is inserted into Queue", node.data);
//}
//public void peek()
//{
//    if (front == null)
//    {
//        Console.WriteLine("Stack is empty");
//    }
//    else
//    {
//        Console.WriteLine("Top element is: " + front.data);
//    }
//}
//public void Display()
//{
//    if (front == null)
//    {
//        Console.WriteLine("Stack is empty");
//    }
//    Node temp = front;
//    while (temp != null)
//    {
//        Console.Write("| " + temp.data + " |");
//        temp = temp.next;
//    }
//}
//public void Dequeue()
//{
//    if (this.front == null)
//    {
//        Console.WriteLine("Queue is empty, deletion is not possible");
//        return;
//    }
//    Console.WriteLine("{0} is element dequeue ", this.front.data);
//    this.front = this.front.next;
//}