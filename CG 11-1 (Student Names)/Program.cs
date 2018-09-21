using System;
using System.Collections.Generic;
using System.IO;

namespace CG_11_1__Student_Names_
{
    class Program
    {
        static void Main(string[] args)
        {

            //Using the text file studentdata.txt write a program that prints out the names of
            //students that have more than six quiz scores.Be sure to use a Student class.


            string[] students = File.ReadAllLines(@"C:\Users\kstar\source\repos\CG 11-1 (Student Names)\CG 11-1 (Student Names)\StudentData.txt");

            List<Student> studentData = new List<Student>();

            foreach (string item in students)
            {
                studentData.Add(new Student(item));

            }

            Console.WriteLine("These students have more than 6 Exam scores: ");
            foreach (Student student in studentData)
            {
                if (student.Scores.Count > 6)
                {
                    string studentCap = char.ToUpper(student.Name[0]) + student.Name.Substring(1);
                    Console.WriteLine(studentCap);
                }

            }


            //StreamReader studentinfo = new StreamReader(@"C:\Users\kstar\source\repos\CG 11-1 (Student Names)\CG 11-1 (Student Names)\StudentData.txt");


            Console.ReadLine();
        }
    }
}
