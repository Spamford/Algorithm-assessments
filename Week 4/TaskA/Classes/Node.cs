using System;
namespace TaskA.Classes
{
    public class Node
    {
        //Variables to store data
        private int data;
        public Node Left, Right;

        //Constructor to create instance of node
        public Node(int item)
        {
            data = item;
            Left = null;
            Right = null;
        }

        //Get and set value for data
        public int Data
        {
            set { data = value; }
            get { return data; }
        }
    }
}
