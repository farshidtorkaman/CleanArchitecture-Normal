using Domain.Common;
using Domain.Enums;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Attribute : AuditableEntity
    {
        public string Title { get; set; }

        public AttributeGroup AttributeGroup { get; set; }

        public int AttributeGroupId { get; set; }

        public AttributeType AttributeType { get; set; }

        public virtual List<AttributeItem> AttributeItems { get; set; }

        public virtual List<ProductAttribute> ProductAttributes { get; set; }
    }
}