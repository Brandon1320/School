using System;
using System.Collections.Generic;

namespace ScholarSystem.Logic.Entity
{
    public class GradeBook
    {
        private readonly List<Grades> grades =
            new List<Grades>();

        public GradeBook(int id, Student student, Subject subject)
        {
            Id = id;
            Student = student ??
                throw new ArgumentNullException(nameof(student));
            Subject = subject ??
                throw new ArgumentNullException(nameof(subject));
        }

        public int Id { get; }
        public Student Student { get; }
        public Subject Subject { get; }
        public Grades[] Grades => grades.ToArray();
        public int TermCount => grades.Count;
        public float Average
        {
            get
            {
                float total = 0;

                foreach (var grade in grades)
                    total += grade.Grade;

                return TermCount == 0 ? 0 :
                    total / TermCount;
            }
        }
    }
}
