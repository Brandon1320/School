using System;

namespace ScholarSystem.Logic.Entity
{
    public abstract class Person
    {
        protected Person(string firstName, string lastName, DateTime birthdate)
        {
            FirstName = firstName ??
                throw new ArgumentNullException(nameof(firstName));
            LastName = lastName ??
                throw new ArgumentNullException(nameof(lastName));

            if (string.IsNullOrWhiteSpace(FirstName))
                throw new ArgumentException();

            if (string.IsNullOrWhiteSpace(LastName))
                throw new ArgumentException();

            Birthdate = birthdate;
        }

        public string FirstName { get; }
        public string LastName { get; }
        public string FullName => LastName + ", " + FirstName;
        public DateTime Birthdate { get; }
        public int Age => DateTime.Compare(Birthdate, DateTime.Now);
    }
}
