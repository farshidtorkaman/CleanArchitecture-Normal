using Domain.Common;

namespace Domain.Entities
{
    public class AttributeGroup : AuditableEntity
    {
        public string Title { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}