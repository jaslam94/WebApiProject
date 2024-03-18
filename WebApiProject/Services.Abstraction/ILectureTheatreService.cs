using Contracts;

namespace Services.Abstraction
{
    public interface ILectureTheatreService
    {
        Task<LectureTheatreDto> AddAsync(LectureTheatreForCreationDto LectureTheatreForCreationDto, CancellationToken cancellationToken = default);

        Task<IEnumerable<LectureTheatreDto>> GetAllAsync(CancellationToken cancellationToken = default);

        Task<LectureTheatreDto> GetByIdAsync(int id, CancellationToken cancellationToken = default);
    }
}