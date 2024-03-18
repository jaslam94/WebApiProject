using Microsoft.AspNetCore.Mvc;
using Services.Abstractions;

namespace WebApiProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LectureTheatresController : ControllerBase
    {
        private readonly ILogger<LectureTheatresController> _logger;
        private readonly IServiceManager _serviceManager;

        public LectureTheatresController(ILogger<LectureTheatresController> logger, IServiceManager serviceManager)
        {
            _logger = logger;
            _serviceManager = serviceManager;
        }
    }
}