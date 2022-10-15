using etickets.Models;
using Microsoft.EntityFrameworkCore;

namespace etickets.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movie>().HasKey(am => new { am.ActorId, am.MovieId });
            modelBuilder.Entity<Actor_Movie>().HasOne(am => am.Movie).WithMany(am => am.Actors_Movies).HasForeignKey(am => am.MovieId);
            modelBuilder.Entity<Actor_Movie>().HasOne(am => am.Actor).WithMany(am => am.Actors_Movies).HasForeignKey(am => am.ActorId);
            base.OnModelCreating(modelBuilder);
        }

		internal Task GetProducersAsync(object id)
		{
			throw new NotImplementedException();
		}

		public DbSet<Actor_Movie> Actors_Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
    }
}
