using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    internal class AttributeItemConfiguration : IEntityTypeConfiguration<AttributeItem>
    {
        public void Configure(EntityTypeBuilder<AttributeItem> builder)
        {
            builder.Property(model => model.Title)
                .HasMaxLength(300)
                .IsRequired();

            builder.HasOne(model => model.Attribute)
                .WithMany(t => t.AttributeItems)
                .HasForeignKey(f => f.AttributeId);
        }
    }
}