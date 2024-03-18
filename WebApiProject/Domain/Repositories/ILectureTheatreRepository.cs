using Domain.Entities;

namespace Domain.Repositories
{
    public interface ILectureTheatreRepository
    {
        Task<IEnumerable<LectureTheatre>> ListAsync(CancellationToken cancellationToken = default);

        Task<LectureTheatre> GetByIdAsync(int Id, CancellationToken cancellationToken = default);

        void Add(LectureTheatre LectureTheatre);

        void Delete(LectureTheatre LectureTheatre);
    }
}