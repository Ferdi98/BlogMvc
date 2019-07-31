using Microsoft.EntityFrameworkCore;
namespace BlogMvc.Models
{
    public class BlogMvcContext : DbContext
    {
        public BlogMvcContext(DbContextOptions<BlogMvcContext> options)
            : base(options)
        {
        }

        public DbSet<BlogMvc.Models.Article> Article { get; set; }
        public DbSet<BlogMvc.Models.Category> Categories { get; set; }
        public DbSet<BlogMvc.Models.Comment> Comments { get; set; }
        public DbSet<BlogMvc.Models.Tag> Tags { get; set; }

        public DbSet<BlogMvc.Models.User> Users { get; set; }

        public DbSet<ArticleTags> ArticleTags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<ArticleTags>()
                .HasKey(at => new { at.ArticleID, at.TagID});

            modelBuilder.Entity<ArticleTags>()
                .HasOne(at => at.Tag)
                .WithMany(a => a.Articles)
                .HasForeignKey(at => at.TagID);


            modelBuilder.Entity<ArticleTags>()
                .HasOne(at => at.Article)
                .WithMany(a => a.ArticleTags)
                .HasForeignKey(at => at.ArticleID);


            base.OnModelCreating(modelBuilder);


        }
    }
}
