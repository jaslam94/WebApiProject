using Domain.Entities;

namespace Domain.Repositories
{
    public interface ISubjectRepository
    {
        Task<IEnumerable<Subject>> ListAsync(CancellationToken cancellationToken = default);

        Task<Subject> GetByIdAsync(int Id, CancellationToken cancellationToken = default);

        List<Lecture> GetLecturesBySubjectId(int subjectId);

        void Add(Subject Subject);

        void Delete(Subject Subject);
    }
}