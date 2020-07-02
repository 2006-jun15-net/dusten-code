using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Data {

    public class MvcMovieContext : DbContext {

        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base (options) {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}