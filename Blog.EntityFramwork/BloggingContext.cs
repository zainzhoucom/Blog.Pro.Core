
using Microsoft.EntityFrameworkCore;

namespace Blog.EntityFramework
{
    public class BloggingContext : DbContext
    {
        public DbSet<Articles> Articles { get; set; }

        public DbSet<Tips> Tips { get; set; }

        public DbSet<ArticleGenre> ArticleGenres { get; set; }

        public BloggingContext(DbContextOptions options) 
            : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("blogging");
            modelBuilder.Entity<ArticleRelationShip>().HasKey(l => new { l.ArticleId, l.TipId });
        }
    }
}
