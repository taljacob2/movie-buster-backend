using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace movie_buster.Models
{
    public class Ticket
    {

        [Key] public int Id { get; set; }

        [ForeignKey("TicketType")]
        public int TicketTypeId { get; set; }
        public TicketType TicketType { get; set; }

        [ForeignKey("Customer")]
        public string CustomerId { get; set; }
        public Customer Customer { get; set; }

        [ForeignKey("Movie")]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
