namespace Domain.Exceptions
{
    public sealed class SubjectNotFoundException : NotFoundException
    {
        public SubjectNotFoundException(int id)
            : base($"The Subject with the id {id} was not found.")
        {
        }
    }
}