namespace Domain.Entities
{
    public class Subject
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public List<Lecture> Lectures { get; set; } = new List<Lecture>();
        public List<Student> EnrolledStudents { get; private set; }

        public Subject()
        {
            EnrolledStudents = new List<Student>();
        }

        public bool CanEnroll(Student student)
        {
            if (Lectures.Count == 0)
                return false;

            if (Lectures.Exists(lecture => lecture.LectureTheatre.CapacityExceeds()))
                return false;

            int totalMinutes = student.EnrolledSubjects.Sum(s => s.Lectures.Sum(l => l.WeeklySchedule.DurationInMinutes));
            if (totalMinutes + Lectures.Sum(l => l.WeeklySchedule.DurationInMinutes) > (10 * 60))
                return false;

            return true;
        }
    }
}