using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace Carsweb.Models
{
    public class Order
    {
        public int Id { get; set; }

        public int CarId { get; set; }

        [ValidateNever]
        public Cars Car { get; set; }

        public int CustomerId { get; set; }

        [ValidateNever]
        public Customer Customer { get; set; }

        public DateTime OrderDate { get; set; }

        public decimal TotalPrice { get; set; }
    }
}