//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace DataStructure
//{
//    //Stacks in Data Structures is a linear type of data structure
//    //Rule
//    //1)Insertion and deletion is possible only from one end
//    //Last In First Out
//    //Push,pop ,peek-return top most element of stack
//    public class Stack_Ex
//    {
//        Node top;
//        public Stack_Ex()
//        {
//            top = null;
//        }
//        public void push(int data)
//        {
//            Node newnode = new Node(data);
//            newnode.next = top;
//            top = newnode;
//        }

//        public void peek()
//        {
//            if (top == null)
//            {
//                Console.WriteLine("Stack is empty");
//            }
//            else
//            {
//                Console.WriteLine("Top element is: " + top.data);
//            }
//        }
//        public void Display()
//        {
//            if(top==null)
//            {
//                Console.WriteLine("Stack is empty");
//            }
//            Node temp = top;
//            while(temp!=null)
//            {
//                Console.Write("| "+temp.data+" |");
//                temp = temp.next;
//            }
//        }
//        public void pop()
//        {
//            if(top==null)
//            {
//                Console.WriteLine("Stack is empty");
//            }
//            this.top = this.top.next;
//        }
        
//    }
//}
