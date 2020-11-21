using Domain.Common;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class AttributeGroup : AuditableEntity
    {
        public string Title { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public virtual List<Attribute> Attributes { get; set; }
    }
}