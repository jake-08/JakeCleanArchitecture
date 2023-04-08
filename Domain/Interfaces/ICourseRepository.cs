using CleanArch.Domain.Models;

namespace CleanArch.Domain.Interfaces
{
    public interface ICourseRepository
    {
        IQueryable<Course> GetCourses();

        void Add(Course course);
    }
}
