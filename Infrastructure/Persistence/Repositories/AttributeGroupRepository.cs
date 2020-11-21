using Application.Repositories;
using Domain.Entities;
using Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories
{
    internal class AttributeGroupRepository : Repository<AttributeGroup>, IAttributeGroupRepository
    {
        public AttributeGroupRepository(ApplicationDbContext context) : base(context)
        {
        }

        public override Task<List<AttributeGroup>> GetAllAsync()
        {
            return _entities.Include(f => f.Category).ToListAsync();
        }
    }
}