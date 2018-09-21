using System;
using System.Collections.Generic;
using System.IO;

namespace CG_11_1__Student_Names_
{
    class Program
    {
        static void Main(string[] args)
        {

           

            //read the data from the text file
            string[] students = File.ReadAllLines(@"C:\Users\kstar\source\repos\CG 11-1 (Student Names)\CG 11-1 (Student Names)\StudentData.txt");

            //initiate new list for all the studentData for each student created
            List<Student> studentData = new List<Student>();

            //loop to add info to each student in list of studentData
            foreach (string item in students)
            {
                studentData.Add(new Student(item));
            }

            Console.WriteLine("These students have more than 6 Exam scores: ");
            Console.WriteLine();

            foreach (Student student in studentData)
            {
                //loop through students in studentData list and print each name
                //that has more than 6 exam scores using method from student class
                //to capitalize first letter in each name
                if (student.Scores.Count > 6)
                {
                    Console.WriteLine(student.StudentNameCap());
                }

            }


            

            Console.ReadLine();
        }
    }
}
