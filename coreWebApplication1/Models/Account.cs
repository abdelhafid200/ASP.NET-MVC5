using System.ComponentModel.DataAnnotations;

namespace coreWebApplication1.Models
{
    public class Account
    {

        [Required]
        [MaxLength(15)]
        [MinLength(3)]
        public string? username { get; set; }
        [Required]
        [MaxLength(15)]
        [MinLength(3)]
        public string? password { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        [Range(18, 60)]
        public int Age { get; set; }
        [Url]
        public string? WebSite { get; set; }

    }
}
