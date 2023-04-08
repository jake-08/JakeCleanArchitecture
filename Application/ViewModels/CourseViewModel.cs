using CleanArch.Domain.Models;

namespace CleanArch.Application.ViewModels
{
    public class CourseViewModel
    {
        public string? Name { get; set; }

        public string? Description { get; set; }

        public string? ImageUrl { get; set; }

        //public IEnumerable<Course>? Courses { get; set; }
    }
}
