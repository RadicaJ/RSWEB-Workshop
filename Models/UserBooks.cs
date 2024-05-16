using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RSWEB.Models
{
    public class UserBooks
    {
        public int Id{get; set; }
        public int BookId {get; set; } //nadvoreshen
        public Book? Book {get; set; }
        [StringLength(450, MinimumLength =3)] public string? AppUser {get; set; }
    }
}