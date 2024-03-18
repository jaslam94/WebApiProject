namespace Contracts
{
    public class LectureDto
    {
        public int Id { get; set; }
        public required WeeklyScheduleDto WeeklySchedule { get; set; }

        public int SubjectId { get; set; }
        public required SubjectDto Subject { get; set; }

        public int LectureTheatreId { get; set; }
        public required LectureTheatreDto LectureTheatre { get; set; }
    }

    public class WeeklyScheduleDto
    {
        public DayOfWeek DayOfWeek { get; set; }
        public TimeSpan StartTime { get; set; }
        public int DurationInMinutes { get; set; }
    }
}