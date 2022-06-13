using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskB.Classes
{
    class Employee
    {
        //create variables for use within the employee class
        private string name;
        private int id;
        private Boolean available;

        //Create name, id and availability variables that are passed in when creating an instance of Employee
        public Employee(string name, int id, Boolean available)
        {
            Name = name;
            Id = id;
            Available = available;
        }

        //Getter and setter methods to get and set value of name, id and availability
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Boolean Available
        {
            get { return available; }
            set { available = value; }
        }

    }
}
