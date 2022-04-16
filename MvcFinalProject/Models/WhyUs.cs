using System.ComponentModel.DataAnnotations;

namespace MvcFinalProject.Models
{
    public class WhyUs
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 100)]
        public string Title { get; set; }
        [Required]
        [StringLength(maximumLength: 300)]
        public string Description { get; set; }
    }
}
