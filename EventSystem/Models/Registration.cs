using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace EventSystem.Models
{
    public class Registration
    {
        public int Id { get; set; }

        [Required]
        public int EventId { get; set; }

        public Event Event { get; set; }

        [Required]
        public string UserId { get; set; }

        public IdentityUser User { get; set; }

        [Required]
        [StringLength(200, ErrorMessage = "Reference number cannot exceed 50 characters.")]
        public string ReferenceNumber { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string EmailAddress { get; set; }
    }

}
