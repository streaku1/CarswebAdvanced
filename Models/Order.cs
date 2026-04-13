using System.ComponentModel.DataAnnotations;

namespace Carsweb.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        public int CarId { get; set; }
        public Cars Car { get; set; }

        [Required]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        [Range(0, 10000000)]
        public decimal TotalPrice { get; set; }
    }
}