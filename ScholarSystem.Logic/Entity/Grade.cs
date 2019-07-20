namespace ScholarSystem.Logic.Entity
{
    public class Grade
    {
        public Grade(Subject subject, float note)
        {
            Subject = subject;
            Note = note;
        }

        public Subject Subject { get; }
        public float Note { get; }
    }
}
