using System;

namespace Lab09.Core
{
    public class School
    {
        private Course[] courses = new Course[100];

        private Student[] students = new Student[10];

        private Teacher[] teachers = new Teacher[10];
        public int CoursesCount { get; private set; }
        public int TeachersCount { get; private set; }
        public int StudentsCount { get; private set; }

        public School()
        {
        }

        public Course GetOrCreateCourse(string courseName)
        {
            Course found = null;
            for (int i = 0; i < CoursesCount; i++)
            {
                if (courses[i].Name == courseName) {
                    found = courses[i];
                    break;
                }
            }
            if (found == null) {
                found = new Course(courseName, CoursesCount);
                courses[CoursesCount++] = found;
            }

            return found;
        }

        public Course GetCourseAt(int index) => courses[index];
        public Student GetStudentAt(int index) => students[index];
        public Teacher GetTeacherAt(int index) => teachers[index];

        public Teacher AddTeacher(string teacherName, decimal salary, string courseName) {
            Teacher t = new Teacher(teacherName, salary, GetOrCreateCourse(courseName));
            teachers[TeachersCount++] = t;
            return t;
        }

        public Student AddStudent(string studentName, string courseName)
        {
            Student s = new Student(studentName, StudentsCount, GetOrCreateCourse(courseName));
            students[StudentsCount++] = s;
            return s;
        }
    }
}