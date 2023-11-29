using huuluan.Domain.Models;
using huuluan.Domain.Persistence.Context.Configurations;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace huuluan.Domain.Persistence.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
 
        public DbSet<Company> Companies { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new CompanyEntityTypeConfiguration());
        }

    }
}
