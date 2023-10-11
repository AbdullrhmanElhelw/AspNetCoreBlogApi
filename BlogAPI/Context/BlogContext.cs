using Microsoft.EntityFrameworkCore;

namespace BlogAPI;

public class BlogContext : DbContext
{
    public BlogContext(DbContextOptions<BlogContext> options) : base(options)
    {
    }

    public DbSet<Post> Posts { get; set; } = null!;
    public DbSet<Category> Categories { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Post>().HasOne(p => p.Category).WithMany(c => c.Posts).HasForeignKey(p => p.CategoryId);
    }
}
