using Contracts;
using Domain.Entities;
using Domain.Repositories;
using Mapster;
using Services.Abstraction;

namespace Services
{
    public class LectureService : ILectureService
    {
        private readonly IRepositoryManager _repositoryManager;

        public LectureService(IRepositoryManager repositoryManager) => _repositoryManager = repositoryManager;

        public async Task<IEnumerable<LectureDto>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            var Lectures = await _repositoryManager.LectureRepository.ListAsync(cancellationToken);

            return Lectures.Adapt<IEnumerable<LectureDto>>();
        }

        public async Task<LectureDto> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            var Lectures = await _repositoryManager.LectureRepository.GetByIdAsync(id, cancellationToken);

            return Lectures.Adapt<LectureDto>();
        }

        public async Task<LectureDto> AddAsync(LectureForCreationDto LectureForCreationDto, CancellationToken cancellationToken = default)
        {
            var Lecture = LectureForCreationDto.Adapt<Lecture>();

            _repositoryManager.LectureRepository.Add(Lecture);

            await _repositoryManager.UnitOfWork.SaveChangesAsync(cancellationToken);

            return Lecture.Adapt<LectureDto>();
        }
    }
}