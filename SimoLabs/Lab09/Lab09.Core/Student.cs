using System.Collections.Generic;

namespace Lab09.Core
{
    public class Student
    {
        
        public Student(string studentName, int studentNumber, Course course)
        {
            Name = studentName;
            Number = studentNumber;
            CurrentlyFollowingCourse = course;
        }

        public string Name { get; set; }
        public int Number { get; set; }
        public Course CurrentlyFollowingCourse { get; set; }
    }
}