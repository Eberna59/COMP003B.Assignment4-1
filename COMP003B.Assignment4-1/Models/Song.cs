using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment4_1.Models
{
    public class Song
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Album { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Year { get; set; }
    }
}
