using Carsweb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Carsweb.Models
{
    public class Cars
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; } = "";

        [Required]
        [StringLength(30)]
        public string Brand { get; set; } = "";

        [Required]
        [Range(1, 10000000)]
        public decimal Price { get; set; }
    }
}