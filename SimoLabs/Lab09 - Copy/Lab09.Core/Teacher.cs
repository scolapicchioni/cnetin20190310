using System.Collections.Generic;

namespace Lab09.Core
{
    public class Teacher : SchoolMember
    {
        public Teacher(string teacherName, decimal salary, Course course): base(teacherName, course)
        {
            Salary = salary;
        }

        public decimal Salary { get; set; }        
    }
}