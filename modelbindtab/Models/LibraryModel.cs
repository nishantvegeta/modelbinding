using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace modelbindtab.Models
{
    public class LibraryModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "Name length cant be more than 10.")]
        public string Name { get; set; }

        [Required]
        public string Stall { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public DateTime? OpenDate { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

    }
}