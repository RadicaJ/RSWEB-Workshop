using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using RSWEB.Models;

namespace RSWEB.Models
{
    public class Genre
    {
        public int Id{get; set; }

        [StringLength(50, MinimumLength =3)] public required string GenreName {get; set;} 

        public ICollection<BookGenre>? BookGenres{get; set; }     

    }
}