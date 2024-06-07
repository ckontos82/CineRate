using System.ComponentModel.DataAnnotations;

namespace CineRate.Models
{
    public class Director
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public ICollection<MovieDirector> MovieDirectors = new List<MovieDirector>();
    }
}
