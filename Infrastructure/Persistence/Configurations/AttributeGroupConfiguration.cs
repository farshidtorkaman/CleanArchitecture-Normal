using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    internal class AttributeGroupConfiguration : IEntityTypeConfiguration<AttributeGroup>
    {
        public void Configure(EntityTypeBuilder<AttributeGroup> builder)
        {
            builder.Property(model => model.Title)
                .HasMaxLength(300)
                .IsRequired();

            builder.HasOne(model => model.Category)
                .WithMany(f => f.AttributeGroups)
                .HasForeignKey(t => t.CategoryId);
        }
    }
}