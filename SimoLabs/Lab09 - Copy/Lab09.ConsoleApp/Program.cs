using Lab09.Core;
using System;

namespace Lab09.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            School school = new School();

            school.AddStudent("Mario", "Math");
            school.AddStudent("Luigi", "Math");
            school.AddStudent("Peach", "C#");
            school.AddStudent("Wario", "C#");

            school.AddTeacher("Zelda", 1234, "Math");
            school.AddTeacher("PacMan", 4321, "C#");

            printCourses(school);
            printTeachers(school);
            printStudents(school);

            Console.ReadLine();
        }

        private static void printStudents(School school)
        {
            Console.WriteLine("**********STUDENTS***********");
            for (int i = 0; i < school.StudentsCount; i++)
            {
                Student s = school.GetStudentAt(i);
                Console.WriteLine($"{s.Name} - {s.Number} - {s.CurrentlyFollowingCourse.Name} - {s.CurrentlyFollowingCourse.Id}");
            }
        }

        private static void printTeachers(School school)
        {
            Console.WriteLine("**********TEACHERS***********");
            for (int i = 0; i < school.TeachersCount; i++)
            {
                Teacher t = school.GetTeacherAt(i);
                Console.WriteLine($"{t.Name} - {t.Salary} - {t.CurrentlyTeachingCourse.Name} - {t.CurrentlyTeachingCourse.Id}");
            }
        }

        private static void printCourses(School school)
        {
            Console.WriteLine("**********COURSES***********");
            for (int i = 0; i < school.CoursesCount; i++)
            {
                Course c = school.GetCourseAt(i);
                Console.WriteLine($"{c.Name} - {c.Id}");
            }
        }
    }
}
