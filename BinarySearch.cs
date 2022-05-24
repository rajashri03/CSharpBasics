//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace DataStructure
//{
//    //Tree
//    ////Binary Tree-Each node has no more tan two children
//    //Common type of binary tree-binary search tree

//    ////11 6 8 19 4 10 5 17 43 49 31
//    class Node
//    {
//        public int item;
//        public Node leftc;
//        public Node Rightc;
//        public Node(int value)
//        {
//            item = value;
//        }
//    }
//    class BinarySearch
//    {
//        public Node root;
//        public BinarySearch()
//        {
//            root = null;
//        }

//        public void Insert(int id)
//        {
//            Node newNode = new Node(id);
//            //newNode.item = id;
//            if (root == null)
//                root = newNode;
//            else
//            {
//                Node current = root;
//                Node parent;
//                while (true)
//                {
//                    parent = current;
//                    if (id < current.item)
//                    {
//                        current = current.leftc;
//                        if (current == null)
//                        {
//                            parent.leftc = newNode;
//                            return;
//                        }
//                    }
//                    else
//                    {
//                        current = current.Rightc;
//                        if (current == null)
//                        {
//                            parent.Rightc = newNode;
//                            return;
//                        }
//                    }
//                }
//            }
//        }
//    }
//}
