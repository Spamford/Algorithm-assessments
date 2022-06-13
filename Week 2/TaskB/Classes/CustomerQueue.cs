using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskB.Classes;

namespace TaskB.Classes
{
    class CustomerQueue
    {
        //set variables for use in programme
        readonly int maxsize = 20;
        String[] customer;
        int head = 0;
        int tail = 0;
        int numItems;

        public CustomerQueue()
        {
            //create customer array the size of max size
            customer = new String[maxsize];
        }

        //Enqueue method that is passed in a string value AKA name of customer
        public void Enqueue(String value)
        {
            //When string is passed in, increase the number of items in queue by 1
            numItems++;
            //Set new customer name to the tail position of the queue
            customer[tail] = value;
            //If the tail is already equal to max size of the queue, set tail back to 0 
            if (tail == maxsize)
            {
                tail = 0;
            }

        }

        public String Dequeue()
        {
            //Create variable head item to store dequeud name
            String headItem;
            //Reduce number of items by 1
            numItems--;
            //Set headitem to customer at head of queue
            headItem = customer[head];
            //If the head of array is equal to max size of array when increased, set head to 0
            if (head == maxsize)
            {
                head = 0;
            }
            //Return value stored in head item
            return headItem;

        }

        public string[] GetCust()
        {
            //Create new arraylist of customers the size of the number of items in the queue
            string[] getcustomers = new string[numItems];

            //loop through until it reaches number of items in the queue
            for (int i = 0; i < numItems; i++)
            {
                //put customer at the head position plus the amount we have incremented
                getcustomers[i] = customer[head + i];
            }
            return getcustomers;
        }

        public void ReverseQueue(int k)
        {
            //create a new stack to store dequeud customers
            Stack<string> reverse = new Stack<string>();

            //store current head and tail of the queue as we will need to revert it later to keep the order
            int reversetail = tail;
            int reversehead = head;
            //set tail to head so we can add the reversed values back to the top of the stack
            tail = head;
            //loop through stack specified k number of times
            for (int i = 0; i < k; i++)
            {
                //push to the stack the dequeud items
                reverse.Push(Dequeue());
            }
            //loop through the stack specified k number of times
            for (int i = 0; i < k; i++)
            {
                //enqueue back to the queue popped stack values
                Enqueue(reverse.Pop());
            }
            tail = reversetail;
            head = reversehead;
        }

        public bool IsEmpty()
        {
            //return yes if number of items in the queue is 0, return no if not
            return numItems == 0;
        }

        public bool IsFull()
        {
            //Return yes if number of items in the queue is equal to the max size allowed, return no if not 
            return numItems == maxsize;
        }

        public int count()
        {
            //returns the number of items in the queue
            return numItems;
        }
    }
}
