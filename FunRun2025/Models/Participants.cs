using System.ComponentModel.DataAnnotations;

namespace FunRun2025.Models
{
    public class Participants
    {
        [Required]
        [Display(Name = "Given Name")]
        public string GivenName { get; set; }

        [Required]
        [Display(Name = "Surname")]
        public string Surname { get; set; }

        [Required]
        [Range(1, 120, ErrorMessage = "Please enter a valid age")]
        public int Age { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        [Display(Name = "Shirt Size")]
        public string ShirtSize { get; set; }
    }
}
