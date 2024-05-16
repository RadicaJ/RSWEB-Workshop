using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RSWEB.Models
{
    public class Author
    {
        public int Id { get; set; }
        [Required] public string? FirstName { get; set; }
        [Required] public string? LastName { get; set; }

        [Display(Name = "Date of birth:")]
        [DataType(DataType.Date)]
        public DateTime? BirthDate { get; set; }
        public string? Nationality { get; set; }
        public string? Gender { get; set; }
        public ICollection<Book>? Books { get; set; }

        public string? FullName
        {
            get { return String.Format("{0} {1}", FirstName, LastName); }
        }

        public int AuthorId { get; internal set; }
    }
}