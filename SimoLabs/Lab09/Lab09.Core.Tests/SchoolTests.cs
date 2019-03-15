using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Lab09.Core.Tests
{
    public class SchoolTests
    {
        [Fact]
        public void GetOrCreateCourseShouldReuseExistingCourseObjectIfNameMatches() {
            School s = new School();

            Course c1 = s.GetOrCreateCourse("Math");
            Course c2 = s.GetOrCreateCourse("Math");

            Assert.Equal(c1, c2);
        }
        [Fact]
        public void GetOrCreateCourseShouldCreateNewCourseObjectIfNameDoesNotMatch()
        {
            School s = new School();

            Course c1 = s.GetOrCreateCourse("Math");
            Course c2 = s.GetOrCreateCourse("C#");

            Assert.NotEqual(c1, c2);
        }
    }
}
