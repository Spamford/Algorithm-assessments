using System;
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
    public partial class AddLabel : Form
    {
        //Create a dictionary of type Employee, with a string key(ID)
        Dictionary<int, Employee> employeedic = new Dictionary<int, Employee>();
        public AddLabel()
        {
            //Add dummy data that is added to the dictionary
            Employee emp1 = new Employee("Sam", 123, true);
            Employee emp2 = new Employee("Anna", 124, false);

            employeedic[emp1.Id] = emp1;
            employeedic[emp2.Id] = emp2;

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            //Clear anything in output list box before rest of code is run
            OutputListBox.Items.Clear();

            //if the inputted key does not match a key in the dictionary, display feedback message
            if (!employeedic.ContainsKey(Convert.ToInt32((InputTextBox.Text))))
            {
                IDFeedbackLabel.Text = "ID not found";
            }
            else
            {
                //If it does, set the feedback label to blank and set the employee b to the values of the inputted
                //ID's dictionary data
                IDFeedbackLabel.Text = " ";
                Employee b = employeedic[Convert.ToInt16(InputTextBox.Text)];
                //Add the name and availability of employee b to the output text box
                OutputListBox.Items.Add("Name: " + b.Name);
                OutputListBox.Items.Add("Available: " + b.Available);
            }

            
        }

        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            //Clear anything in output list box before rest of code is run
            IDListBox.Items.Clear();
            OutputListBox.Items.Clear();
            IDFeedbackLabel.Text = " ";
            ChangeFeedbackLabel.Text = " ";
            AddFeedbackLabel.Text = " ";

            //for each entry in the dictionary, add the ID to the ID list box
            foreach (KeyValuePair<int, Employee> item in employeedic)
            {
                IDListBox.Items.Add(item.Value.Id);
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {

            OutputListBox.Items.Clear();
            IDListBox.Items.Clear();
            IDFeedbackLabel.Text = " ";
            ChangeFeedbackLabel.Text = " ";
            AddFeedbackLabel.Text = " ";

            //If inputted key does not match key in dictionairy, display feedback message
            if (!employeedic.ContainsKey(Convert.ToInt32((RemoveTextBox.Text))))
            {
                IDFeedbackLabel.Text = "ID not found";
            }

            //If it does match, give feedback accordingly, set string s to the value of inputted id in remove text box
            //Remove string s entry from the dictionary
            else
            {
                IDFeedbackLabel.Text = "Employee Removed";
                int s = Convert.ToInt32(RemoveTextBox.Text);
                employeedic.Remove(s);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            OutputListBox.Items.Clear();
            IDListBox.Items.Clear();
            IDFeedbackLabel.Text = " ";
            ChangeFeedbackLabel.Text = " ";

            //Create new instance of Employee called employee with the inputted values, and set availability to true
            Employee employee = new Employee(NameTextBox.Text, Convert.ToInt32(IDTextBox.Text), true);
            
            //Add the new employee to the dictionary
            employeedic[Convert.ToInt32(IDTextBox.Text)] = employee;

            //Give feedback accordingly
            AddFeedbackLabel.Text = "Employee Added Successfully";
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            OutputListBox.Items.Clear();
            IDFeedbackLabel.Text = " ";
            AddFeedbackLabel.Text = " ";

            //If inputted ID does not match an existing key, give feedback accordingly
            if (!employeedic.ContainsKey(Convert.ToInt32((ChangeTextBox.Text))))
            {
                IDFeedbackLabel.Text = "ID not found";
            }

            //If it does match, set Employee c to the values of corresponding entry in the dictionary
            else
            {
                IDFeedbackLabel.Text = " ";
                Employee c = employeedic[Convert.ToInt32(ChangeTextBox.Text)];

                //Change availability to other option, based on what it already is and give feedback accordingly
                if (c.Available == true)
                {
                    c.Available = false;
                    ChangeFeedbackLabel.Text = "Availability changed to False";
                }
                else if (c.Available == false)
                {
                    c.Available = true;
                    ChangeFeedbackLabel.Text = "Availability changed to True";
                }
            }
        }

        private void IDListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Set Employee selectedId to the value of the selected entry within the dictionary
            Employee selectedId = employeedic[Convert.ToInt32(IDListBox.SelectedItem)];

            //Clear output list box
            OutputListBox.Items.Clear();
            IDFeedbackLabel.Text = " ";
            ChangeFeedbackLabel.Text = " ";
            AddFeedbackLabel.Text = " ";

            //Add name and availabiliy to the output list box
            OutputListBox.Items.Add("Name: " + selectedId.Name);
            OutputListBox.Items.Add("Available: " + selectedId.Available);
        }
    }
}
