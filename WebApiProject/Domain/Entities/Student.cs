namespace Domain.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public required string FullName { get; set; }
        public List<Subject> EnrolledSubjects { get; private set; }

        public Student()
        {
            EnrolledSubjects = new List<Subject>();
        }
    }
}