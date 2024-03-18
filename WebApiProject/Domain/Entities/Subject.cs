namespace Domain.Entities
{
    public class Subject
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public List<Lecture> Lectures { get; set; } = new List<Lecture>();
    }
}