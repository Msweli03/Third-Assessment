using System.ComponentModel.DataAnnotations;

namespace EventSystem.Models
{
    public class Event
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Total seats must be at least 1.")]
        public int TotalSeats { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Seats available cannot be negative.")]
        public int SeatsAvailable { get; set; }

        public ICollection<Registration> Registrations { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }
    }


}
