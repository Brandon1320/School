using System;

namespace ScholarSystem.Logic.Entity
{
    public class GradeBook
    {
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
        public float[] Grades { get; } = { 0f, 0f, 0f };
        public float Average
        {
            get
            {
                float total = 0;

                foreach (var grade in Grades)
                    total += grade;

                return total / 3;
            }
        }
    }
}
