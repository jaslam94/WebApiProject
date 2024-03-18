using Contracts;
using Microsoft.AspNetCore.Mvc;
using Services.Abstractions;
using WebApiProject.Contracts;

namespace WebApiProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public StudentsController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            return Ok(await _serviceManager.StudentService.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAccountById(int id, CancellationToken cancellationToken)
        {
            var accountDto = await _serviceManager.StudentService.GetByIdAsync(id, cancellationToken);

            return Ok(accountDto);
        }

        [HttpGet("retrieve")]
        public async Task<IActionResult> Retrieve(int subjectId, CancellationToken cancellationToken)
        {
            var response = await _serviceManager.StudentService.RetrieveAsync(subjectId, cancellationToken);

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] StudentForCreationDto studentForCreationDto, CancellationToken cancellationToken)
        {
            var response = await _serviceManager.StudentService.AddAsync(studentForCreationDto, cancellationToken);

            return CreatedAtAction(nameof(Add), new { id = response.Id }, response);
        }
    }
}