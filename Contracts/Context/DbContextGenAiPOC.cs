using GenAiPoc.Contracts.Models;
using Microsoft.EntityFrameworkCore;

namespace GenAiPoc.Contracts.Context
{
    public class DbContextGenAiPOC : DbContext
    {
        public DbContextGenAiPOC(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Projects> Projects{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FileDetails>()
                .HasOne(f => f.Project)
                .WithMany(p => p.Files)
                .HasForeignKey(f => f.ProjectId);
        }
    }
}
