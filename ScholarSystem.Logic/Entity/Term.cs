using System.Collections.Generic;

namespace ScholarSystem.Logic.Entity
{
    public class Term
    {
        private readonly Dictionary<int, float> grades =
            new Dictionary<int, float>();

        public Term() { }

        public int GradeCount => grades.Count;

        public void AddGrade(Subject subject, float note) =>
            grades.Add(subject.Id, note);

        public void RemoveGrade(Subject subject) =>
            grades.Remove(subject.Id);

        public Grade GetGrade(Subject subject)
        {
            if (!grades.TryGetValue(subject.Id, out var note))
                throw new System.ArgumentException();

            return new Grade(subject, note);
        }

        public float GetAverage()
        {
            float sum = 0;

            foreach (var grade in grades)
                sum += grade.Value;

            return grades.Count == 0 ? 0 :
                sum / grades.Count;
        }
    }
}
