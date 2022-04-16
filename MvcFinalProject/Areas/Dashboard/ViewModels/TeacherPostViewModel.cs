using Microsoft.AspNetCore.Http;
using MvcFinalProject.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcFinalProject.Areas.ViewModels
{
    public class TeacherPostViewModel
    {
        //get

        [Required]
        public string MainImage { get; set; }

        [Required]
        public string Title { get; set; }
        [Required]
        public string DetailImage { get; set; }
        [Required]
        [StringLength(30)]

        public string Fullname { get; set; }
        [Required]
        public string Profession { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [StringLength(maximumLength: 200)]
        
        public List<int> SkillIds { get; set; }
        public int ContactId { get; set; }
        public IFormFile ImageFile { get; set; }

        public Contact Contact { get; set; }
        public List<Skill> Skills { get; set; }

    }
}
