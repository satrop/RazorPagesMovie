#nullable disable
using Microsoft.EntityFrameworkCore;

namespace RazorPagesMovie.Data
{
#pragma warning disable CS8632
    public class RazorPagesMovieContext : DbContext
    {
#pragma warning disable CS8632
        public RazorPagesMovieContext (DbContextOptions<RazorPagesMovieContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie.Models.Movie>? Movie { get; set; }
    }
}
