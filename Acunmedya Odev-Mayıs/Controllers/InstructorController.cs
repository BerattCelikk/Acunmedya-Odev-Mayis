using Microsoft.AspNetCore.Mvc;
using YourProjectName.Exceptions;
using Acunmedya_Odev_Mayıs.Entities;
using Acunmedya_Odev_Mayıs.Services;

namespace YourProjectName.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InstructorController : ControllerBase
    {
        private readonly InstructorService _instructorService;

        public InstructorController(InstructorService instructorService)
        {
            _instructorService = instructorService;
        }

        [HttpPost("create")]
        public IActionResult CreateInstructor([FromBody] Instructor instructor)
        {
            if (string.IsNullOrWhiteSpace(instructor.FullName))
            {
                throw new BusinessException("Instructor adı boş olamaz");
            }

            var dto = _instructorService.GetInstructorDTO(instructor);
            return Ok(dto);
        }
    }
}
