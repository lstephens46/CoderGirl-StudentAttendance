using System;
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
            string[] lines = File.ReadAllLines(@"studentdata.txt");

            //foreach (var student in students)
            //{
            //    Console.WriteLine($"{student.Name}");
            //}
            Student student = CreateStudentObject(lines[0]);
            
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