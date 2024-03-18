using Contracts;
using Domain.Entities;
using Domain.Repositories;
using Mapster;
using Services.Abstraction;

namespace Services
{
    public class SubjectService : ISubjectService
    {
        private readonly IRepositoryManager _repositoryManager;

        public SubjectService(IRepositoryManager repositoryManager) => _repositoryManager = repositoryManager;

        public async Task<IEnumerable<SubjectDto>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            var Subjects = await _repositoryManager.SubjectRepository.ListAsync(cancellationToken);

            return Subjects.Adapt<IEnumerable<SubjectDto>>();
        }

        public async Task<SubjectDto> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            var Subjects = await _repositoryManager.SubjectRepository.GetByIdAsync(id, cancellationToken);

            return Subjects.Adapt<SubjectDto>();
        }

        public async Task<SubjectDto> AddAsync(SubjectForCreationDto SubjectForCreationDto, CancellationToken cancellationToken = default)
        {
            var Subject = SubjectForCreationDto.Adapt<Subject>();

            _repositoryManager.SubjectRepository.Add(Subject);

            await _repositoryManager.UnitOfWork.SaveChangesAsync(cancellationToken);

            return Subject.Adapt<SubjectDto>();
        }
    }
}