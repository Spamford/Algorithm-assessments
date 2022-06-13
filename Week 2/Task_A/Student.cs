using System;
namespace Assessed_Exercise_1
{
    public class Student
    {
        //Defines the three variables needed within the program, name, id and age
        private string name;
        private int id;
        private int age;

        //Set name, id and age to the values that are passed into the student constructor
        public Student(string name, int id, int age)
        {
            this.name = name;
            this.id = id;
            this.age = age;
        }

        //getter and setter methods to get and set the value of name, id and age for use within the array
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

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        //Create string with the values of instance of student
        public string GetInfo()
        {
            String returnInfo = this.name + ", " + this.id + ", " + this.age;
            return returnInfo;
        }

    }
}
