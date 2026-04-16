using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment4_1.Models
{
    public class ConcertRegistration
    {
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string City { get; set; }

        [Range(1, 8)]
        public int TicketCount { get; set; }
    }
}
