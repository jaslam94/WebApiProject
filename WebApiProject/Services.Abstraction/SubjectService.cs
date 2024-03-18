using Contracts;

namespace Services.Abstraction
{
    public interface ISubjectService
    {
        Task<SubjectDto> AddAsync(SubjectForCreationDto SubjectForCreationDto, CancellationToken cancellationToken = default);

        Task<IEnumerable<SubjectDto>> GetAllAsync(CancellationToken cancellationToken = default);

        Task<SubjectDto> GetByIdAsync(int id, CancellationToken cancellationToken = default);
    }
}