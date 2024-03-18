namespace Domain.Exceptions
{
    public sealed class StudentNotFoundException : NotFoundException
    {
        public StudentNotFoundException(int id)
            : base($"The student with the id {id} was not found.")
        {
        }
    }
}