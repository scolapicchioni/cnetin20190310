using System.Collections.Generic;

namespace Lab09.Core
{
    public class Student : SchoolMember
    {
        public Student(string studentName, int studentNumber, Course course) : base(studentName,course)
        {
            Number = studentNumber;
        }
        
        public int Number { get; set; }
    }
}