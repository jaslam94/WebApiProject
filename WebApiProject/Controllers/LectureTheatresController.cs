using Contracts;
using Microsoft.AspNetCore.Mvc;
using Services.Abstractions;

namespace WebApiProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LectureTheatresController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public LectureTheatresController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            return Ok(await _serviceManager.LectureTheatreService.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAccountById(int id, CancellationToken cancellationToken)
        {
            var accountDto = await _serviceManager.LectureTheatreService.GetByIdAsync(id, cancellationToken);

            return Ok(accountDto);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] LectureTheatreForCreationDto LectureTheatreForCreationDto, CancellationToken cancellationToken)
        {
            var response = await _serviceManager.LectureTheatreService.AddAsync(LectureTheatreForCreationDto, cancellationToken);

            return CreatedAtAction(nameof(Add), new { id = response.Id }, response);
        }
    }
}