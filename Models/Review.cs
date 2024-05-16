using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using RSWEB.Models;


namespace RSWEB.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public Book? Book { get; set; }

        [StringLength(450, MinimumLength = 3)] public string? AppUser { get; set; }
        [StringLength(500, MinimumLength = 3)] public string? Comment { get; set; }
        public int Rating { get; set; }

    }
}