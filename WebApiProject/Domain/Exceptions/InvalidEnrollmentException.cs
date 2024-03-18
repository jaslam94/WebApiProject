namespace WebApiProject.Domain.Exceptions
{
    public class InvalidEnrollmentException : Exception
    {
        public InvalidEnrollmentException() : base("Enrollment would exceed capacity or student's weekly schedule.")
        {
        }
    }
}