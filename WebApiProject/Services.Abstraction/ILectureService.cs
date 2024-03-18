using Contracts;

namespace Services.Abstraction
{
    public interface ILectureService
    {
        Task<LectureDto> AddAsync(LectureForCreationDto LectureForCreationDto, CancellationToken cancellationToken = default);

        Task<IEnumerable<LectureDto>> GetAllAsync(CancellationToken cancellationToken = default);

        Task<LectureDto> GetByIdAsync(int id, CancellationToken cancellationToken = default);
    }
}