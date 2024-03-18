namespace Contracts
{
    public class LectureForCreationDto
    {
        public int Id { get; set; }
        public required WeeklyScheduleDto WeeklySchedule { get; set; }
        public int SubjectId { get; set; }
        public int LectureTheatreId { get; set; }
    }
}