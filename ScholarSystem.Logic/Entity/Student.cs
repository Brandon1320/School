using System;

namespace ScholarSystem.Logic.Entity
{
    public class Student : Person
    {
        public Student(int id, string firstName, string lastName,
            DateTime birthDate) : base(firstName, lastName, birthDate)
        {
            Id = id;
        }

        public int Id { get; }
        public string Email { get; set; }
    }
}
