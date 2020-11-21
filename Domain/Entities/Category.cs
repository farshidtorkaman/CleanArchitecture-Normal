using Domain.Common;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Category : AuditableEntity
    {
        public string Name { get; set; }

        public Category Parent { get; set; }

        public int? ParentId { get; set; }

        public virtual List<Category> Categories { get; set; }

        public virtual List<ProductCategory> ProductCategories { get; set; }

        public virtual List<AttributeGroup> AttributeGroups { get; set; }
    }
}