namespace Contracts
{
    public class StudentDto
    {
        public int Id { get; set; }
        public required string FullName { get; set; }
        public List<SubjectDto> EnrolledSubjects { get; set; } = new List<SubjectDto>();
    }
}