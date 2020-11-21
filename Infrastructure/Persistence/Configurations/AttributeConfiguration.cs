using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    internal class AttributeConfiguration : IEntityTypeConfiguration<Attribute>
    {
        public void Configure(EntityTypeBuilder<Attribute> builder)
        {
            builder.Property(model => model.Title)
                .HasMaxLength(300)
                .IsRequired();

            builder.HasOne(model => model.AttributeGroup)
                .WithMany(t => t.Attributes)
                .HasForeignKey(f => f.AttributeGroupId);
        }
    }
}