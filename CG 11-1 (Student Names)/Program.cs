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

            //foreach loop to add info to each student in list of studentData
            foreach (string item in students)
            {
                studentData.Add(new Student(item));
            }

            Console.WriteLine("These students have more than 6 Exam scores: ");

            foreach (Student student in studentData)
            {
                //foreach loop to loop through students in studentData list and print each name
                //that has more than 6 exam scores
                if (student.Scores.Count > 6)
                {
                    //capitalize the first letter in each name that prints
                    string studentCap = char.ToUpper(student.Name[0]) + student.Name.Substring(1);
                    Console.WriteLine(studentCap);
                }

            }


            

            Console.ReadLine();
        }
    }
}
