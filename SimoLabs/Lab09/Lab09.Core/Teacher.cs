using System.Collections.Generic;

namespace Lab09.Core
{
    public class Teacher
    {
        public Teacher(string teacherName, decimal salary, Course course)
        {
            Name = teacherName;
            Salary = salary;
            CurrentlyTeachingCourse = course;
        }

        public string Name { get; set; }
        public decimal Salary { get; set; }
        public Course CurrentlyTeachingCourse { get; set; }
    }
}