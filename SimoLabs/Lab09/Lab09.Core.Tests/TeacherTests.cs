using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Lab09.Core.Tests
{
    public class TeacherTests
    {
        [Fact]
        public void ConstructorShouldInitializeAllProperties()
        {
            string courseName = "Math";
            string teacherName = "teacherName";
            decimal teacherSalary = 1000;
            Course course = new Course(courseName);

            Teacher teacher = new Teacher(teacherName, teacherSalary, course);

            Assert.Equal(teacherName, teacher.Name);
            Assert.Equal(teacherSalary, teacher.Salary);
            Assert.Equal(course, teacher.CurrentlyTeachingCourse);

        }
    }
}
