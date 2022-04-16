using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcFinalProject.Models
{
    public class Slider
    {
        
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 300)]
        public string Image { get; set; }
        [Required]
        
        [StringLength(maximumLength: 170)]
        public string TopTitle { get; set; }
        [StringLength(maximumLength: 170)]
        public string BottomTitle { get; set; }
        [Required]
        [StringLength(maximumLength: 300)]
        public string Description { get; set; }
        [Required]
        public byte Order { get; set; }

        [NotMapped]
        [Required]
        public IFormFile ImageFile { get; set; }
    }
}
