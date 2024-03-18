using Contracts;
using Microsoft.AspNetCore.Mvc;
using Services.Abstractions;

namespace WebApiProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LecturesController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public LecturesController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            return Ok(await _serviceManager.LectureService.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAccountById(int id, CancellationToken cancellationToken)
        {
            var accountDto = await _serviceManager.LectureService.GetByIdAsync(id, cancellationToken);

            return Ok(accountDto);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] LectureForCreationDto LectureForCreationDto, CancellationToken cancellationToken)
        {
            var response = await _serviceManager.LectureService.AddAsync(LectureForCreationDto, cancellationToken);

            return CreatedAtAction(nameof(Add), new { id = response.Id }, response);
        }
    }
}