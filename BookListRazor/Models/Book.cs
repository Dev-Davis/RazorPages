using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookListRazor.Models
{
    public class Book
    {
        // automatically add Id as an identity column
        [Key]
        public int Id { get; set; }

        // Required means that the name cannot be null
        [Required]
        public string Name { get; set; }
        public string Author { get; set; }
    }
}
