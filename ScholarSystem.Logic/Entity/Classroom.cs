namespace ScholarSystem.Logic.Entity
{
    public class Classroom
    {
        public Classroom(int id)
        {
            Id = id;
        }

        public int Id { get; }
        public string Location { get; set; }
    }
}
