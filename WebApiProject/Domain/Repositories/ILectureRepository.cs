using Contracts;
using Domain.Entities;

namespace Domain.Repositories
{
    public interface ILectureRepository
    {
        Task<IEnumerable<Lecture>> ListAsync(CancellationToken cancellationToken = default);

        Task<Lecture> GetByIdAsync(int Id, CancellationToken cancellationToken = default);

        void Add(Lecture Lecture);

        void Delete(Lecture Lecture);

        Task<Lecture> EnrollStudent(StudentDto student, CancellationToken cancellationToken = default);
    }
}