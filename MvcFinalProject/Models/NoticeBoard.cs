using System;
using System.ComponentModel.DataAnnotations;

namespace MvcFinalProject.Models
{
    public class NoticeBoard
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        [Required]
        [StringLength(maximumLength: 200)]
        public string Description { get; set; }
    }
}
