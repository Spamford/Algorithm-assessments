using System;
using TaskA.Classes;

namespace TaskA
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Add nodes to tree
            Node root = new Node(3);
            root.Left = new Node(1);
            root.Right = new Node(2);
            root.Right.Left = new Node(5);
            root.Right.Right = new Node(6);
            root.Left.Left = new Node(4);

            //Create a new tree
            BinTree mytree = new BinTree(root);

            //Call InOrder on the tree and store the data in s string
            string s = " ";
            mytree.InOrder(ref s);

            Console.WriteLine("InOrder: " + s);

            //Call PreOrder on the tree and store the data in t string
            string t = " ";
            mytree.PreOrder(ref t);

            Console.WriteLine("PreOrder: " + t);

            //Call PostOrder on the tree and store the data in u string
            string u = " ";
            mytree.PostOrder(ref u);

            Console.WriteLine("PostOrder: " + u);

            Console.ReadKey();
        }
    }
}
