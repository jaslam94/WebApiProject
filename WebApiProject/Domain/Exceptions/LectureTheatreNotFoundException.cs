namespace Domain.Exceptions
{
    public sealed class LectureTheatreNotFoundException : NotFoundException
    {
        public LectureTheatreNotFoundException(int id)
            : base($"The Lecture Theatre with the id {id} was not found.")
        {
        }
    }
}