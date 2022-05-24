using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    //Tree
    //Binary Tree-Each node has no more tan two children
    //11 6 8 19 4 10 5 17 43 49 31

    class Node
    {
        public int item;
        public Node leftc;
        public Node rightc;
        public Node(int data)
        {
            item = data;
            leftc = null;
            rightc = null;
        }

    }
    class Tree
    {
        public Node root;
        public Tree()
        {
            root = null;
        }
        public Node ReturnRoot()
        {
            return root;
        }
        public void Insert(int id)
        {
            Node newNode = new Node(id);
            //newNode.item = id;
            if (root == null)
                root = newNode;
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (id < current.item)
                    {
                        current = current.leftc;
                        if (current == null)
                        {
                            parent.leftc = newNode;
                            return;
                        }
                    }
                    else
                    {
                        current = current.rightc;
                        if (current == null)
                        {
                            parent.rightc = newNode;
                            return;
                        }
                    }
                }
            }
        }
        //Preorder
        public void Display(Node Root)
        {
            if (Root != null)
            {
                Console.Write(Root.item + " ");
                Display(Root.leftc);
                Display(Root.rightc);
            }
        }
        public void Post(Node Root)
        {
            if (Root != null)
            {
                Post(Root.leftc);
                Post(Root.rightc);
                Console.Write(Root.item + " ");
               
              
            }
        }
        public void Inorder(Node Root)
        {
            if (Root != null)
            {
               Inorder(Root.leftc);
                Console.Write(Root.item + " ");
               Inorder(Root.rightc);
            }
        }
    }

}
