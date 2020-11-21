namespace Domain.Common
{
    public class BaseEntity<TPrimaryKey> where TPrimaryKey : struct
    {
        public TPrimaryKey Id { get; set; }
    }

    public class BaseEntity : BaseEntity<int>
    {
    }
}