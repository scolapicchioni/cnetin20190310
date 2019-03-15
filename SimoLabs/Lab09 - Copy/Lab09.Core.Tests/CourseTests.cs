using System;
using Xunit;

namespace Lab09.Core.Tests
{
    public class CourseTests
    {
        [Fact]
        public void ConstructorShouldInitializeAllProperties()
        {
            string name = "Math";
            Course course = new Course(name,1);

            Assert.Equal(name, course.Name);
            Assert.Equal(1, course.Id);
        }
    }
}
