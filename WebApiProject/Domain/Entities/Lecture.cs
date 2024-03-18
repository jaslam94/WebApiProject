namespace Domain.Entities
{
    public class Lecture
    {
        public int Id { get; set; }
        public required WeeklySchedule WeeklySchedule { get; set; }

        public int SubjectId { get; set; }
        public required Subject Subject { get; set; }

        public int LectureTheatreId { get; set; }
        public required LectureTheatre LectureTheatre { get; set; }
    }

    public class WeeklySchedule
    {
        public DayOfWeek DayOfWeek { get; set; }
        public TimeSpan StartTime { get; set; }
        public int DurationInMinutes { get; set; }
    }

    public enum DayOfWeek
    {
        Monday = 1, Tuesday = 2, Wednesday = 3, Thursday = 4, Friday = 5, Saturday = 6, Sunday = 7
    }
}