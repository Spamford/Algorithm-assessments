using System;

namespace Assessed_Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an array of type student called arraystudent with a size of 10
            Student[] arraystudent = new Student[10];

            //At each point in the array, add a new student
            arraystudent[0] = new Student("Sam", 1, 23);
            arraystudent[1] = new Student("Tim", 2, 25);
            arraystudent[2] = new Student("Anna", 3, 22);
            arraystudent[3] = new Student("Bob", 4, 27);
            arraystudent[4] = new Student("Rachel", 5, 29);
            arraystudent[5] = new Student("Amy", 6, 30);
            arraystudent[6] = new Student("Lewis", 7, 20);
            arraystudent[7] = new Student("Max", 8, 23);
            arraystudent[8] = new Student("Tina", 9, 26);
            arraystudent[9] = new Student("Gene", 10, 25);

            //For loop iterated 10 times
            for (int i = 0; i < 10; i++)
            {
                //Write each student to the console
                Console.WriteLine(arraystudent[i].GetInfo());
            }

            //Pause console
            Console.ReadKey();
        }
    }
}
