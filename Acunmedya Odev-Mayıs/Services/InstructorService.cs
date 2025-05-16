using Acunmedya_Odev_Mayıs.DTOs;
using Acunmedya_Odev_Mayıs.Entities;
using AutoMapper;


namespace YourProjectName.Services
{
    public class InstructorService
    {
        private readonly IMapper _mapper;

        public InstructorService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public InstructorDTO GetInstructorDTO(Instructor instructor)
        {
            return _mapper.Map<InstructorDTO>(instructor);
        }
    }
}
