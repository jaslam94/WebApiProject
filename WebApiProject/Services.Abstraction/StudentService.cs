using Contracts;

namespace Services.Abstraction
{
    public interface IStudentService
    {
        Task<StudentDto> AddAsync(StudentForCreationDto studentForCreationDto, CancellationToken cancellationToken = default);

        Task<IEnumerable<StudentDto>> GetAllAsync(CancellationToken cancellationToken = default);

        Task<StudentDto> GetByIdAsync(int id, CancellationToken cancellationToken = default);
    }
}