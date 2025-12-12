using AutoMapper;
using OnlineEdu.DTO.DTOs.CourseRegisterDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.Api.Mapping
{
    public class CourseRegisterMapping:Profile
    {
        public CourseRegisterMapping()
        {
            CreateMap<ResultCourseRegisterDto, CourseRegister>().ReverseMap();

            CreateMap<CreateCourseRegisterDto, CourseRegister>().ReverseMap();
            CreateMap<UpdateCourseRegisterDto, CourseRegister>().ReverseMap();
        }
    }
}
