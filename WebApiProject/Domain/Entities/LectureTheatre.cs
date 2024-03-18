namespace Domain.Entities
{
    public class LectureTheatre
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int Capacity { get; set; }

        public List<Lecture> Lectures { get; set; } = new List<Lecture>();
    }
}