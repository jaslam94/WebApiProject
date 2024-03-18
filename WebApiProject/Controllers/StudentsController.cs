using Microsoft.AspNetCore.Mvc;
using Services;
using Services.Abstractions;

namespace WebApiProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly ILogger<StudentsController> _logger;
        private readonly IServiceManager _serviceManager;

        public StudentsController(ILogger<StudentsController> logger, IServiceManager serviceManager)
        {
            _logger = logger;
            _serviceManager = serviceManager;
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            return Ok(await _serviceManager.StudentService.GetAllAsync());
        }
    }
}