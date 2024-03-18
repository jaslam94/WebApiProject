using Domain.Entities;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories
{
    internal sealed class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public StudentRepository(ApplicationDbContext dbContext) => _dbContext = dbContext;

        public void Add(Student Student) => _dbContext.Students.Add(Student);

        public void Update(Student Student) => _dbContext.Students.Update(Student);

        public void Delete(Student Student) => _dbContext.Students.Remove(Student);

        public Task<Student> EnrollStudent(Student student, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Student>> ListAsync(CancellationToken cancellationToken = default) =>
            await _dbContext.Students.Include(m => m.EnrolledSubjects).ToListAsync(cancellationToken);

        public async Task<Student> GetByIdAsync(int Id, CancellationToken cancellationToken = default) =>
            await _dbContext.Students.Include(x => x.EnrolledSubjects).ThenInclude(m => m.Lectures).FirstOrDefaultAsync(x => x.Id == Id, cancellationToken);

        public async Task<IEnumerable<Student>> GetBySubjectIdAsync(int subjectId, CancellationToken cancellationToken) =>
            await _dbContext.Students.Where(m => m.EnrolledSubjects.Select(m => m.Id).Contains(subjectId)).ToListAsync(cancellationToken);
    }
}