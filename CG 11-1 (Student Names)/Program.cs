using System;
using System.IO;

namespace CG_11_1__Student_Names_
{
    class Program
    {
        static void Main(string[] args)
        {

            //Using the text file studentdata.txt write a program that prints out the names of
            //students that have more than six quiz scores.Be sure to use a Student class.


            Student student = new Student();
            



            

            string[] students = File.ReadAllLines(@"C:\Users\kstar\source\repos\CG 11-1 (Student Names)\CG 11-1 (Student Names)\StudentData.txt");

            //foreach (string item in students)
            //{
                




            //}


            //StreamReader studentinfo = new StreamReader(@"C:\Users\kstar\source\repos\CG 11-1 (Student Names)\CG 11-1 (Student Names)\StudentData.txt");


            Console.ReadLine();
        }
    }
}
