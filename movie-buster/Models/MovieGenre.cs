using System.ComponentModel.DataAnnotations;

namespace movie_buster.Models
{
    public class MovieGenre
    {

        [Key] public int Id { get; set; }

        [MaxLength(50)] public string Title { get; set; }

        public int AgeLimit { get; set; }  
    }
}
