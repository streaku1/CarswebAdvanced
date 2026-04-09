using System.ComponentModel.DataAnnotations;

namespace Carsweb.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; } = "";

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; } = "";

        [Phone(ErrorMessage = "Invalid phone number")]
        public string Phone { get; set; } = "";

        public string Address { get; set; } = "";
    }
}
