using Microsoft.AspNetCore.Mvc;
using Services.Abstractions;

namespace WebApiProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LecturesController : ControllerBase
    {
        private readonly ILogger<LecturesController> _logger;
        private readonly IServiceManager _serviceManager;

        public LecturesController(ILogger<LecturesController> logger, IServiceManager serviceManager)
        {
            _logger = logger;
            _serviceManager = serviceManager;
        }
    }
}