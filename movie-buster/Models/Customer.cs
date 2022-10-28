using System.ComponentModel.DataAnnotations;

namespace movie_buster.Models
{
    public class Customer
    {

        [Key] public string Id { get; set; }

        [MaxLength(50)] public string FirstName { get; set; }

        [MaxLength(50)] public string LastName { get; set; }

        public int Age { get; set; }  
    }
}
