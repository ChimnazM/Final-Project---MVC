using System.ComponentModel.DataAnnotations;

namespace MvcFinalProject.Models
{
    public class Contact
    {
        public int Id { get; set; }
        [Required]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        [Required]
        public string Skype { get; set; }
        public string FacebookUrl { get; set; }
        public string PinterestUrl { get; set; }
        public string InstagramUrl { get; set; }
        public string TwitterUrl { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }

    }
}
