using System;

namespace ScholarSystem.Logic.Entity
{
    public class Student : Person
    {
        public Student(int id, string firstName, string lastName,
            DateTime birthdate) : base(firstName, lastName, birthdate)
        {
            Id = id;
        }

        public int Id { get; }
        public string Email { get; set; }
    }
}
