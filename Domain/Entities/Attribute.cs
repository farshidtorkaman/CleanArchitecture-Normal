using Domain.Common;
using Domain.Enums;

namespace Domain.Entities
{
    public class Attribute : AuditableEntity
    {
        public string Title { get; set; }

        public AttributeGroup AttributeGroup { get; set; }

        public int AttributeGroupId { get; set; }

        public AttributeType AttributeType { get; set; }
    }
}