using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace movie_buster.Models
{
    public class Movie
    {
        [Key] public int Id { get; set; }

        [MaxLength(50)] public string Title { get; set; }

        [ForeignKey("MovieGenre")]
        public int MovieGenreId { get; set; }
        public MovieGenre MovieGenre { get; set; }
    }
}
