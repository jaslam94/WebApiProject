using System.ComponentModel.DataAnnotations;

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

    public struct WeeklyScheduleDto
    {
        public DayOfWeek DayOfWeek { get; set; }

        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:HH:mm:ss}")]
        public string StartTime { get; set; }
        public int DurationInMinutes { get; set; }
    }
}