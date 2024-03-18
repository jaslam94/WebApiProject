namespace Contracts
{
    public class SubjectDto
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public List<LectureDto> Lectures { get; set; } = new List<LectureDto>();
    }
}