using Domain.Common;

namespace Domain.Entities
{
    public class ProductCategory : AuditableEntity
    {
        public Category Category { get; set; }

        public int CategoryId { get; set; }

        public Product Product { get; set; }

        public int ProductId { get; set; }
    }
}