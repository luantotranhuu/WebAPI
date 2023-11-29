using huuluan.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace huuluan.Domain.Persistence.Context.Configurations
{
    public class CompanyEntityTypeConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x=> x.Name).HasMaxLength(256);
            builder.HasMany(x => x.Categories).WithOne(x => x.Company).HasForeignKey(x => x.CompanyId);
        }
    }
}
