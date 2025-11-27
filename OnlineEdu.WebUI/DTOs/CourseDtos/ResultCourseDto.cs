using OnlineEdu.DTO.DTOs.CourseCategoryDtos;
using OnlineEdu.WebUI.DTO.CourseCategoryDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.WebUI.DTO.CourseDtos
{
    public class ResultCourseDto
    {
        public int CourseId { get; set; }

        public string CourseName { get; set; }

        public string ImageUrl { get; set; }

        public int CourseCategoryId { get; set; }

        public ResultCourseCategoryDto CourseCategory { get; set; }

        public decimal Price { get; set; }

        public bool IsShown { get; set; }
    }
}
