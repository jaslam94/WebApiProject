using Contracts;
using Microsoft.AspNetCore.Mvc;
using Services.Abstractions;
using WebApiProject.Contracts;

namespace WebApiProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SubjectsController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public SubjectsController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            return Ok(await _serviceManager.SubjectService.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAccountById(int id, CancellationToken cancellationToken)
        {
            var accountDto = await _serviceManager.SubjectService.GetByIdAsync(id, cancellationToken);

            return Ok(accountDto);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] SubjectForCreationDto SubjectForCreationDto, CancellationToken cancellationToken)
        {
            var response = await _serviceManager.SubjectService.AddAsync(SubjectForCreationDto, cancellationToken);

            return CreatedAtAction(nameof(Add), new { id = response.Id }, response);
        }

        [HttpGet("retrieve")]
        public async Task<IActionResult> Retrieve(int studentId, CancellationToken cancellationToken)
        {
            var response = await _serviceManager.SubjectService.RetrieveAsync(studentId, cancellationToken);

            return Ok(response);
        }

        [HttpPost("enroll")]
        public async Task<IActionResult> Enroll([FromBody] EnrollStudentDto EnrollStudentDto, CancellationToken cancellationToken)
        {
            await _serviceManager.SubjectService.EnrollAsync(EnrollStudentDto, cancellationToken);

            return Ok();
        }
    }
}