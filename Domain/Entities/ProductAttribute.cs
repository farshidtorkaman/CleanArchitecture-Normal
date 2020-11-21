using Domain.Common;

namespace Domain.Entities
{
    public class ProductAttribute : AuditableEntity
    {
        public Product Product { get; set; }

        public int ProductId { get; set; }

        public Attribute Attribute { get; set; }

        public int AttributeId { get; set; }

        public string Value { get; set; }

        public AttributeItem AttributeItem { get; set; }

        public int? AttributeItemId { get; set; }

        public bool IsChecked { get; set; }
    }
}