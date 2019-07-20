using System;
using System.Collections.Generic;

namespace ScholarSystem.Logic.Entity
{
    public class Class
    {
        private readonly List<Student> studentList =
            new List<Student>();

        public Class(int id, Subject subject)
        {
            Id = id;
            Subject = subject ??
                throw new ArgumentNullException(nameof(subject));
        }

        public Class(int id, Subject subject, Classroom classroom,
            Professor professor) : this(id, subject)
        {
            Classroom = classroom;
            Professor = professor;
        }

        public int Id { get; }
        public Subject Subject { get; }
        public Classroom Classroom { get; set; }
        public Professor Professor { get; set; }
        public Student[] StudentList => studentList.ToArray();
    }
}
