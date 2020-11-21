using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    internal class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.HasOne(model => model.Product)
                .WithMany(f => f.ProductCategories)
                .HasForeignKey(t => t.ProductId);

            builder.HasOne(model => model.Category)
                .WithMany(f => f.ProductCategories)
                .HasForeignKey(t => t.CategoryId);
        }
    }
}