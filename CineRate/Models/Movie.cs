using Microsoft.AspNetCore.Mvc.Formatters;
using System.ComponentModel.DataAnnotations;

namespace CineRate.Models
{
    public class Movie
    {
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Year { get; set; }
        public ICollection<MovieDirector> MovieDirectors = new List<MovieDirector>();
        public ICollection<Rating> Ratings { get; set; } = new List<Rating>();

        public float AverageRating
        {
            get
            {
                if (Ratings != null && Ratings.Any())
                {
                    return (float)Ratings.Average(r => r.RatingValue);
                }
                return 0;
            }
        }
    }
}
