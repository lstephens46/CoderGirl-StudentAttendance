using System;
using System.Collections.Generic;
using System.IO;
namespace StudentAttendance
{
    public static class Program
    {
        //program so that the values for the student class are populated from the included studentdata.txt file. 
        //The student’s name is the first thing on each line, followed by some exam scores. 
        //The number of scores might be different for each student.  
        //The program should print out the names of students that have more than six quiz scores.

        public static void Main()
        {
            List<Student> students = new List<Student>();

            string[] lines = File.ReadAllLines(@"studentdata.txt");
            foreach (var line in lines)
            {
                Student student = CreateStudentObject(line);
                if (student.HasSixOrMore())
                {
                    students.Add(student);
                }
            }

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name}");
            }
            
            Console.ReadLine();
            
        }
        public static Student CreateStudentObject(string studentLine)
        {
            Student student = new Student();
            string[] data = studentLine.Split(" ");
            student.Name = data[0];
            student.Scores = GetTestScores(studentLine);

            return student;
        }

        private static int[] GetTestScores(string studentLine)
        {
            string[] data = studentLine.Split(" ");
            int[] scores = new int[data.Length - 1];
            for (int i = 1; i < data.Length; i++)
            {
                int score = int.Parse(data[i]);
                scores.SetValue(score, i - 1);
            }
            return scores;
        }


    }

}