using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskB.Classes;

namespace TaskB
{
    public partial class Form1 : Form
    {
        //Create new queue called myqueue
        CustomerQueue myqueue = new CustomerQueue();

        public Form1()
        {
            InitializeComponent();
        }

        private void EnqueueButton_Click(object sender, EventArgs e)
        {
            //if queue is full, set feedback label to say Queue is Full
             if (myqueue.IsFull())
            {
                FeedbackLabel.Text = "Queue is Full";
            }
            else
            {
                //If queue is not full, enqueue the text that has been inputted in the name entry text box
                myqueue.Enqueue(NameEntryTextBox.Text);
                //Give feedback that data has been added to the queue
                FeedbackLabel.Text = "Data added to Queue!";
                //Add the inputted name to the list view, showing full contents of the queue
                DisplayListBox.Items.Add(NameEntryTextBox.Text);
                //Set counter to the number of items in the queue
                CountTextBox.Text = myqueue.count().ToString();
            }
        }

        private void DequeueButton_Click(object sender, EventArgs e)
        {
            //If queue is empty, set feedback label to sat that it is empty
            if (myqueue.IsEmpty())
            {
                FeedbackLabel.Text = "No Data! Queue is Empty";
            }
            else
            {
                //Use dequeue to remove last inputted name and give feedback that this has been done
                myqueue.Dequeue();
                FeedbackLabel.Text = "Item Dequeued";
                //Remove most recent item from the list view, accurately reflecting the name being removed from the queue
                DisplayListBox.Items.RemoveAt(0);
                //Set counter accordingly
                CountTextBox.Text = myqueue.count().ToString();
            }
        }

        private void KButton_Click(object sender, EventArgs e)
        {
            //Call reverse queue function on myqueue passing in user input of k value
            myqueue.ReverseQueue(Convert.ToInt32(KTextBox.Text));
            //Clear the listbox
            KListBox.Items.Clear();
            //Call getcustomers and display result in K list box
            KListBox.Items.AddRange(myqueue.GetCust());

        }
    }
    
}
