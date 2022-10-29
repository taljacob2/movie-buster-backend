using System.ComponentModel.DataAnnotations;

namespace movie_buster.Models
{
    public class TicketType
    {
        [Key] public int Id { get; set; }

        [MaxLength(50)] public string Title { get; set; }

        public float Price { get; set; }
    }
}
