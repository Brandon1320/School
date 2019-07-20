using System;

namespace ScholarSystem.Logic.Entity
{
    public class Professor : Person
    {
        public Professor(int id, string firstName, string lastName,
            DateTime birthDate) : base(firstName, lastName, birthDate)
        {
            Id = id;
        }

        public int Id { get; }
    }
}
