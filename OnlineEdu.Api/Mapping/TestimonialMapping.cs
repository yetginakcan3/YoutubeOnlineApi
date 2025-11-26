using AutoMapper;
using OnlineEdu.DTO.DTOs.TestimonialDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.Api.Mapping
{
    public class TestimonialMapping : Profile
    {
        public TestimonialMapping()
        {
            CreateMap<CreateTestimonialDto, Testimonial>().ReverseMap();
            CreateMap<UpdateTestimonialDto, Testimonial>().ReverseMap();
        }
    }
}
