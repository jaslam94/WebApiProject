using System.ComponentModel.DataAnnotations;

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

    public struct WeeklySchedule
    {
        public DayOfWeek DayOfWeek { get; set; }

        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:HH:mm:ss}")]
        public string StartTime { get; set; }
        public int DurationInMinutes { get; set; }
    }
}