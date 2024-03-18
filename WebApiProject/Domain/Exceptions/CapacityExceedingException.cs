namespace WebApiProject.Domain.Exceptions
{
    public class CapacityExceedingException : Exception
    {
        public CapacityExceedingException(int id)
            : base($"The capacity of lecture theatre has reached limit. Cannot add more students to the lecture with the id {id}.")
        {
        }
    }
}