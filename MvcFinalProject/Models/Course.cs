using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcFinalProject.Models
{
    public class Course
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 150)]
        public string Image { get; set; }
        [Required]
        [StringLength(maximumLength: 100)]
        public string MainTitle { get; set; }
        [Required]

        
        public string MainDesc { get; set; }
        [Required]
        public string ApplyDesc { get; set; }
        public List<CourseCategory> CourseCategories { get; set; }
        public Feature Feature { get; set; }
        [NotMapped]
        [Required]
        public IFormFile ImageFile { get; set; }
    }
}
