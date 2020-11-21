using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    internal class ProductAttributeConfiguration : IEntityTypeConfiguration<ProductAttribute>
    {
        public void Configure(EntityTypeBuilder<ProductAttribute> builder)
        {
            builder.HasOne(model => model.Attribute)
                .WithMany(f => f.ProductAttributes)
                .HasForeignKey(t => t.AttributeId);

            builder.HasOne(model => model.AttributeItem)
                .WithMany(f => f.ProductAttributes)
                .HasForeignKey(t => t.AttributeItemId);

            builder.HasOne(model => model.Product)
                .WithMany(f => f.ProductAttributes)
                .HasForeignKey(t => t.ProductId);

            builder.Property(model => model.IsChecked)
                .HasDefaultValue(false);
        }
    }
}