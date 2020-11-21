using Domain.Common;

namespace Domain.Entities
{
    public class AttributeItem : AuditableEntity
    {
        public string Title { get; set; }

        public Attribute Attribute { get; set; }

        public int AttributeId { get; set; }
    }
}