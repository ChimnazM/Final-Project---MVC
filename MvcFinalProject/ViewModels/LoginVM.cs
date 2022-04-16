using System.ComponentModel.DataAnnotations;

namespace MvcFinalProject.ViewModels
{
    public class LoginVM
    {
        [Required]
        public string Login { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
