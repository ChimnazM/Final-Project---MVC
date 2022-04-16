namespace MvcFinalProject.Models
{
    public class CourseCategory
    {

        public int Id { get; set; }
        public int CourseId { get; set; }
        public int CategoryId { get; set; }
        public Course Courses { get; set; }
        public Category Category { get; set; }
    }
}
