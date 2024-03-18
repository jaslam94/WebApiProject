using Microsoft.AspNetCore.Mvc;
using Services.Abstractions;

namespace WebApiProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SubjectsController : ControllerBase
    {
        private readonly ILogger<SubjectsController> _logger;
        private readonly IServiceManager _serviceManager;

        public SubjectsController(ILogger<SubjectsController> logger, IServiceManager serviceManager)
        {
            _logger = logger;
            _serviceManager = serviceManager;
        }
    }
}