namespace Domain.Repositories
{
    public interface IRepositoryManager
    {
        IStudentRepository StudentRepository { get; }
        ISubjectRepository SubjectRepository { get; }
        ILectureRepository LectureRepository { get; }
        ILectureTheatreRepository LectureTheatreRepository { get; }
        IUnitOfWork UnitOfWork { get; }
    }
}