using System.ComponentModel.DataAnnotations;

namespace Carsweb.Models
{
    public class Review
    {
        public int Id { get; set; }

        [Required]
        public string Comment { get; set; }

        [Range(1,10)]
        public int Rating { get; set; }

        public int CarId { get; set; }
        public Cars Car { get; set; }
    }
}