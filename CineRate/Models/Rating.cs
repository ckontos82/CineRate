using System.ComponentModel.DataAnnotations;

namespace CineRate.Models
{
    public class Rating
    {
        public Guid Id { get; set; }
        public Guid MovieId { get; set; }
        public Movie Movie { get; set; }
        [Required]
        public string UserId { get; set; } // Assuming you will implement authentication
        [Range(1, 10)]
        public int RatingValue { get; set; }
    }
}
