using Microsoft.AspNetCore.Http;
using MvcFinalProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcFinalProject.Areas.Dashboard.ViewModels
{
    public class EventPostVM
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        public string Image { get; set; }
        [Required]
        public string ImageDetail { get; set; }
        public string ImageMain { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        public string Title { get; set; }
        [Required]
        [StringLength(maximumLength: 1000)]
        public string Description { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string VenueMain { get; set; }
        [Required]
        public string VenueDetail { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        public string Time { get; set; }
        public Event Event { get; set; }
        public List<int> SpeakerIds { get; set; }
        public List<Speaker> Speakers { get; set; }
        public IFormFile ImageFile { get; set; }

    }
}
