using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CG_11_1__Student_Names_
{
    public class Student
    {
        //properties for student class: string Name, and int List of scores
        public string Name { get; set; }

        public List<int> Scores { get; set; }

        public Student(string studentData)
        {
            //initiate string for splitting data from text file
            string[] studentdataSplit = studentData.Split("; ");

            //initiate the list of scores
            Scores = new List<int>();

            //designate first item on each line as name, 
            //and other items on each line as scores
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


    }   
}
