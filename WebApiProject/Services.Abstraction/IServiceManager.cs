using Services.Abstraction;

namespace Services.Abstractions
{
    public interface IServiceManager
    {
        IStudentService StudentService { get; }
        ISubjectService SubjectService { get; }
        ILectureService LectureService { get; }
        ILectureTheatreService LectureTheatreService { get; }
    }
}