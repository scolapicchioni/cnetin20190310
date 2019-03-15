using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Lab09.Core.Tests
{
    public class StudentTests
    {
        [Fact]
        public void ConstructorShouldInitializeAllProperties()
        {
            string courseName = "Math";
            string studentName = "studentName";
            int studentNumber = 1;
            Course course = new Course(courseName);

            Student student = new Student(studentName, studentNumber, course);

            Assert.Equal(studentName, student.Name);
            Assert.Equal(studentNumber, student.Number);
            Assert.Equal(course, student.CurrentlyFollowingCourse);

        }
    }
}
