using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hash = new Hashtable();
            hash.Add("Id", 1111);
            hash.Add("Name", "Raj");
            hash.Add("City", "Kop");

            Console.WriteLine(hash["Name"]);








            Tree theTree = new Tree();
            theTree.Insert(40);
            theTree.Insert(30);
            theTree.Insert(50);
            theTree.Insert(65);
            theTree.Insert(25);
            theTree.Insert(18);
            theTree.Insert(78);
            theTree.Insert(31);


            Console.WriteLine("Preorder Traversal :Root-Left-right ");
            theTree.Display(theTree.ReturnRoot());

            Console.WriteLine("\n");
            Console.WriteLine("Post Traversal :Left-right-Root ");
            theTree.Post(theTree.ReturnRoot());


            Console.WriteLine("\n");

            Console.WriteLine("Inorder Traversal :Left-Root-right ");
            theTree.Inorder(theTree.ReturnRoot());

        }
    }
}
