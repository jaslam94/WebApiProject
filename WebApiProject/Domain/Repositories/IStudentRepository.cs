using Domain.Entities;

namespace Domain.Repositories
{
    public interface IStudentRepository
    {
        Task<IEnumerable<Student>> ListAsync(CancellationToken cancellationToken = default);

        Task<Student> GetByIdAsync(int Id, CancellationToken cancellationToken = default);

        void Add(Student Student);

        void Delete(Student Student);
    }
}