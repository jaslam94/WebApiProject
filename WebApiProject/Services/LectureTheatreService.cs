using Contracts;
using Domain.Entities;
using Domain.Repositories;
using Mapster;
using Services.Abstraction;

namespace Services
{
    public class LectureTheatreService : ILectureTheatreService
    {
        private readonly IRepositoryManager _repositoryManager;

        public LectureTheatreService(IRepositoryManager repositoryManager) => _repositoryManager = repositoryManager;

        public async Task<IEnumerable<LectureTheatreDto>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            var LectureTheatres = await _repositoryManager.LectureTheatreRepository.ListAsync(cancellationToken);

            return LectureTheatres.Adapt<IEnumerable<LectureTheatreDto>>();
        }

        public async Task<LectureTheatreDto> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            var LectureTheatres = await _repositoryManager.LectureTheatreRepository.GetByIdAsync(id, cancellationToken);

            return LectureTheatres.Adapt<LectureTheatreDto>();
        }

        public async Task<LectureTheatreDto> AddAsync(LectureTheatreForCreationDto LectureTheatreForCreationDto, CancellationToken cancellationToken = default)
        {
            var LectureTheatre = LectureTheatreForCreationDto.Adapt<LectureTheatre>();

            _repositoryManager.LectureTheatreRepository.Add(LectureTheatre);

            await _repositoryManager.UnitOfWork.SaveChangesAsync(cancellationToken);

            return LectureTheatre.Adapt<LectureTheatreDto>();
        }
    }
}