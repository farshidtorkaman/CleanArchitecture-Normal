using Application.Repositories;
using Domain.Entities;
using Infrastructure.Persistence.Contexts;

namespace Infrastructure.Persistence.Repositories
{
    internal class AttributeItemRepository : Repository<AttributeItem>, IAttributeItemRepository
    {
        public AttributeItemRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}