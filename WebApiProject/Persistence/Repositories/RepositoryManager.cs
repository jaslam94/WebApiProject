using Domain.Repositories;

namespace Persistence.Repositories
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly Lazy<ISubjectRepository> _lazySubjectRepository;
        private readonly Lazy<IStudentRepository> _lazyStudentRepository;
        private readonly Lazy<ILectureRepository> _lazyLectureRepository;
        private readonly Lazy<ILectureTheatreRepository> _lazyLectureTheatreRepository;
        private readonly Lazy<IUnitOfWork> _lazyUnitOfWork;

        public RepositoryManager(ApplicationDbContext dbContext)
        {
            _lazySubjectRepository = new Lazy<ISubjectRepository>(() => new SubjectRepository(dbContext));
            _lazyStudentRepository = new Lazy<IStudentRepository>(() => new StudentRepository(dbContext));
            _lazyLectureRepository = new Lazy<ILectureRepository>(() => new LectureRepository(dbContext));
            _lazyLectureTheatreRepository = new Lazy<ILectureTheatreRepository>(() => new LectureTheatreRepository(dbContext));

            _lazyUnitOfWork = new Lazy<IUnitOfWork>(() => new UnitOfWork(dbContext));
        }

        public ISubjectRepository SubjectRepository => _lazySubjectRepository.Value;
        public IStudentRepository StudentRepository => _lazyStudentRepository.Value;
        public ILectureRepository LectureRepository => _lazyLectureRepository.Value;
        public ILectureTheatreRepository LectureTheatreRepository => _lazyLectureTheatreRepository.Value;

        public IUnitOfWork UnitOfWork => _lazyUnitOfWork.Value;
    }
}