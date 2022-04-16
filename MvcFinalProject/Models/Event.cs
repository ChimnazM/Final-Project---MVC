using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcFinalProject.Models
{
    public class Event
    {
        public int Id { get; set; }
        [Required]
        public string ImageMain { get; set; }
        [Required]
        public string ImageDetail { get; set; }
        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string Time { get; set; }
        [Required]
        public string VenueMain { get; set; }
        [Required]
        public string VenueDetail { get; set; }
        [Required]
        public string Description { get; set; }
       

        public List<EventSpeaker> EventSpeakers { get; set; }
        [NotMapped]
        [Required]
        public IFormFile ImageFile { get; set; }

    }
}
