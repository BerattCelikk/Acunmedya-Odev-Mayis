using AutoMapper;

using Acunmedya_Odev_Mayıs.DTOs;
using Acunmedya_Odev_Mayıs.Entities;

namespace YourProjectName.MappingProfiles
{
    public class InstructorProfile : Profile
    {
        public InstructorProfile()
        {
            CreateMap<Instructor, InstructorDTO>();
            CreateMap<InstructorDTO, Instructor>();
        }
    }
}
