using System;
using System.Collections.Generic;
using System.Text;

namespace Lab09.Core
{
    public class SchoolMember
    {
        public SchoolMember(string name, Course course)
        {
            Name = name;
            CurrentCourse = course;
        }
        public string Name { get; set; }
        public Course CurrentCourse { get; set; }
    }
}
