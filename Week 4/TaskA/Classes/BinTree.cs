using System;
namespace TaskA.Classes
{
    public class BinTree
    {
        private Node root;

        //Create empty tree with no root
        public BinTree()
        {
            root = null;
        }

        //Create tree with root as the passed in node
        public BinTree(Node node)
        {
            root = node;
        }

        // in order function passes in a reference string to store values
        public void InOrder(ref string buffer)
        {
            inOrder(root, ref buffer);
        }

        //Pass in tree root node
        private void inOrder(Node tree, ref string buffer)
        {
            
            if (tree != null)
            {
                //Call inOrder on the left subtree
                inOrder(tree.Left, ref buffer);

                //Get the data within the node and assign it to the buffer string
                buffer += tree.Data.ToString() + ",";

                //Call inOrder on the right subtree
                inOrder(tree.Right, ref buffer);
            }

        }

        public void PreOrder(ref string buffer)
        {
            preOrder(root, ref buffer);
        }

        private void preOrder(Node tree, ref string buffer)
        {
            if (tree != null)
            {
                //Get data within the node and assign it to the buffer string
                buffer += tree.Data.ToString() + ",";

                //Call preOrder on the left subtree
                preOrder(tree.Left, ref buffer);

                //Call preOrder on the right subtree
                preOrder(tree.Right, ref buffer);
            }

        }

        public void PostOrder(ref string buffer)
        {
            postOrder(root, ref buffer);
        }

        private void postOrder(Node tree, ref string buffer)
        {
            if (tree != null)
            {
                //Call PostOrder on the left subtree
                postOrder(tree.Left, ref buffer);

                //Call postOrder on the right subtree
                postOrder(tree.Right, ref buffer);

                //Get data within the node and assign it to the buffer string
                buffer += tree.Data.ToString() + ",";
            }

        }
    }
}
