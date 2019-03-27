using System;

namespace StudentAttendance
{
    public class Student
    {
        //program so that the values for the student class are populated from the included studentdata.txt file. 
        //The student’s name is the first thing on each line, followed by some exam scores. 
        //The number of scores might be different for each student.  
        //The program should print out the names of students that have more than six quiz scores.

        public string Name { get; set; }

        public int[] Scores { get; set; }

        public bool HasSixOrMore()
        {
            if (Scores.Length >= 6)
            {
                return true;
            }
            return false;
        }
    }
}