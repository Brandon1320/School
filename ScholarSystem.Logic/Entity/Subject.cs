using System;

namespace ScholarSystem.Logic.Entity
{
    public class Subject
    {
        private string name;

        public Subject(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; }
        public string Name
        {
            get => name;
            set
            {
                if (value == null)
                    throw new ArgumentNullException();
                else if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException();
                else
                    name = value.Trim();
            }
        }
    }
}
