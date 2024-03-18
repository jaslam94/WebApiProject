namespace Contracts
{
    public class LectureTheatreForCreationDto
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int Capacity { get; set; }
    }
}