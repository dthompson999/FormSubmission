using System.ComponentModel.DataAnnotations;
namespace FormSubmission.Models
{
    public class User
    {
        [Required]
        [MinLength(4)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        [MinLength(4)]
        public string LastName { get; set; }

        [Required]
        [Range(0,150)]
        public int Age { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(8)]
        public string Password { get; set; }
    }
}