using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RSWEB.Models;

namespace RSWEB.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<RSWEB.Models.Book> Book { get; set; } = default!;
        public DbSet<RSWEB.Models.Author> Author { get; set; } = default!;
        public DbSet<RSWEB.Models.BookGenre> BookGenre { get; set; } = default!;
        public DbSet<RSWEB.Models.Genre> Genre { get; set; } = default!;
        public DbSet<RSWEB.Models.Review> Review { get; set; } = default!;
        public DbSet<RSWEB.Models.UserBooks> UserBooks { get; set; } = default!;
    }
}
