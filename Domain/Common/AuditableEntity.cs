using System;

namespace Domain.Common
{
    public class AuditableEntity<TPrimaryKey> : BaseEntity<TPrimaryKey> where TPrimaryKey : struct
    {
        public string CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }
    }

    public class AuditableEntity : AuditableEntity<int>
    {
    }
}