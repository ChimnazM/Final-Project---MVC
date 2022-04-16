using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcFinalProject.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        [Required]
        public string MainImage { get; set; }
       
        [Required]
        public string Title { get; set; }
        [Required]
        public string DetailImage { get; set; }
        [Required]
        [StringLength(30)]

        public string  Fullname { get; set; }
        [Required]
        public string Profession { get; set; }
        [Required]
        public string Description { get; set; }
        public Contact Contact { get; set; }
        public List<Skill> Skill { get; set; }
        //public IFormFile imageFile { get; set; }

    }
}
