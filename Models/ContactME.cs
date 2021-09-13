using System.ComponentModel.DataAnnotations;

namespace CineMania.Models
{
    public class ContactMe
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(200, ErrorMessage="please insert your name clearly")]
        public string Names { get; set; }
        [Required]
        [MaxLength(200, ErrorMessage="your email should be true")]
        public string Email { get; set; }
        [Required]
        [MaxLength(2000, ErrorMessage="Description should not exceed 200 characters")]
        public string Subject { get; set; }
        [Required]
        [MaxLength(2000, ErrorMessage="please put your comment here")]
        
        public string Comment { get; set; }
        
    }
}
