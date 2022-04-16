using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcFinalProject.Areas.Dashboard.ViewModels
{
    public class SliderMultiVM
    {
        [Required]
        [StringLength(maximumLength: 300)]
        public string Desc { get; set; }
        [Required]
        [StringLength(maximumLength: 170)]
        public string Title { get; set; }

        [NotMapped]
        [Required]
        public IFormFile[] Images { get; set; }
    }
}

