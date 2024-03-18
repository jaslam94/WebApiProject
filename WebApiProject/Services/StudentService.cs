using Contracts;
using Domain.Entities;
using Domain.Repositories;
using Mapster;
using Services.Abstraction;

namespace Services
{
    public class StudentService : IStudentService
    {
        private readonly IRepositoryManager _repositoryManager;

        public StudentService(IRepositoryManager repositoryManager) => _repositoryManager = repositoryManager;

        public async Task<IEnumerable<StudentDto>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            var students = await _repositoryManager.StudentRepository.ListAsync(cancellationToken);

            return students.Adapt<IEnumerable<StudentDto>>();
        }

        public async Task<StudentDto> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            var students = await _repositoryManager.StudentRepository.GetByIdAsync(id, cancellationToken);

            return students.Adapt<StudentDto>();
        }

        public async Task<StudentDto> AddAsync(StudentForCreationDto studentForCreationDto, CancellationToken cancellationToken = default)
        {
            var student = studentForCreationDto.Adapt<Student>();

            _repositoryManager.StudentRepository.Add(student);

            await _repositoryManager.UnitOfWork.SaveChangesAsync(cancellationToken);

            return student.Adapt<StudentDto>();
        }
    }
}