using Microsoft.AspNetCore.Http;
using MvcFinalProject.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcFinalProject.Areas.Dashboard.ViewModels
{
    public class CoursePostVM
    {
        [Required]
        [StringLength(maximumLength: 150)]
        public string Image { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        public string MainTitle { get; set; }
        [Required]
        [StringLength(maximumLength: 150)]
        public string MainDesc { get; set; }
        [Required]
        [StringLength(maximumLength: 150)]
        public string AboutDesc { get; set; }
        [Required]
        [StringLength(maximumLength: 150)]
        public string ApplyDesc { get; set; }
        [Required]
        [StringLength(maximumLength: 150)]
        public string CertificationDesc { get; set; }
        public List<int> CategoryIds { get; set; }
        public int FeatureId { get; set; }
        public IFormFile ImageFile { get; set; }
        public Feature Feature { get; set; }
        public List<Category> Categories { get; set; }
    }
}

