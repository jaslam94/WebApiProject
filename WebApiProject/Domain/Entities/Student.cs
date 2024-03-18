using Domain.Repositories;
using WebApiProject.Domain.Exceptions;

namespace Domain.Entities
{
    public class Student
    {
        public int Id { get; private set; }
        public string FullName { get; private set; }
        public List<Subject> EnrolledSubjects  { get; private set; }

        public Student(int id, string fullName)
        {
            Id = id;
            FullName = fullName;
            EnrolledSubjects = new List<Subject>();
        }

        public bool CanEnroll(Subject subject, ISubjectRepository subjectRepository)
        {
            foreach (var lecture in subjectRepository.GetLecturesBySubjectId(subject.Id))
            {
                if (lecture.LectureTheatre.Lectures.Count >= lecture.LectureTheatre.Capacity)
                {
                    return false;
                }
            }

            int totalHours = EnrolledSubjects.Sum(s => s.Lectures.Sum(l => l.WeeklySchedule.DurationInMinutes / 60));
            if (totalHours + subject.Lectures.Sum(l => l.WeeklySchedule.DurationInMinutes / 60) > 10 * 60)
            {
                return false;
            }

            return true;
        }

        public void Enroll(Subject subject, ISubjectRepository subjectRepository)
        {
            if (!CanEnroll(subject, subjectRepository))
            {
                throw new InvalidEnrollmentException();
            }

            EnrolledSubjects.Add(subject);
        }
    }
}