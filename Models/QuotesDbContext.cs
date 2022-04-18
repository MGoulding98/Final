using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models
{
    public class QuotesDbContext : DbContext
    {
        public QuotesDbContext(DbContextOptions<QuotesDbContext> options) : base(options)
        {

        }

        public DbSet<Quote> Quotes { get; set; }

        // seed the database
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Quote>().HasData(
                new Quote { QuoteID = 1, QuoteText = "No form of art goes beyond ordinary consciousness as film does, straight to our emotions, deep into the twilight room of the soul.", Author = "Ingmar Bergman", Date = "April 4, 1946", Subject = "Film", Citation = "The Internet" },
                new Quote { QuoteID = 2, QuoteText = "The cinema is not an art which films life: the cinema is something between art and life.", Author = "Jean-Luc Godard", Date = "June 1965", Subject = "Film", Citation = "The Internet" },
                new Quote { QuoteID = 3, QuoteText = "It’s better not to know so much about what things mean or how they might be interpreted or you’ll be too afraid to let things keep happening.", Author = "David Lynch", Date = "September 2003", Subject = "Film", Citation = "The Internet" }
                );
        }
    }
}
