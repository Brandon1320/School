using System;
using System.Collections.Generic;

namespace ScholarSystem.Logic.Entity
{
    public class GradeBook
    {
        private List<Term> terms = new List<Term>();

        public GradeBook(int id, Student student)
        {
            Id = id;
            Student = student ??
                throw new ArgumentNullException(nameof(student));
        }

        public int Id { get; }
        public Student Student { get; }
        public Term[] Terms => terms.ToArray();

        public float GetAverage()
        {
            float total = 0;

            foreach (var term in Terms)
                total += term.GetAverage();

            return terms.Count == 0 ? 0 :
                total / terms.Count;
        }
    }
}
