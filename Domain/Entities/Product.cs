using Domain.Common;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Product : AuditableEntity
    {
        public string Title { get; set; }

        public string ShortDescription { get; set; }

        public string Description { get; set; }

        public virtual List<ProductCategory> ProductCategories { get; set; }

        public virtual List<ProductAttribute> ProductAttributes { get; set; }
    }
}