using System.Collections.Generic;

namespace Lab09.Core
{
    public class Course
    {
        internal Course(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public string Name { get; }
        public int Id { get; }
    }
}