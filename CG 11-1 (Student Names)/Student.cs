using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CG_11_1__Student_Names_
{
    public class Student
    {

        public string Name { get; set; }
        
        public List<int> Scores { get; set; }

        public Student(string studentData)
        {
            string[] studentdataSplit = studentData.Split("; ");
            Scores = new List<int>();
            for (int i = 0; i < studentdataSplit.Length; i++)
            {
                if (i == 0)
                {
                    Name = studentdataSplit[i];
                }
                else
                {
                    int score = int.Parse(studentdataSplit[i]);
                    Scores.Add(score);
                }
                

            }

        }


        //public string StudentData { get; set; }

        //    StreamReader studentinfo = new StreamReader(@"C:\Users\kstar\source\repos\CG 11-1 (Student Names)\CG 11-1 (Student Names)\StudentData.txt");

        //    public string ReadData()
        //    {
        //        StudentData = studentinfo.ReadLine();
        //        return StudentData;
        //    }

        


        }
}
