using Application.Repositories;
using Domain.Entities;
using Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories
{
    internal class AttributeRepository : Repository<Attribute>, IAttributeRepository
    {
        public AttributeRepository(ApplicationDbContext context) : base(context)
        {
        }

        public override Task<List<Attribute>> GetAllAsync()
        {
            return _entities.Include(f => f.AttributeGroup).ToListAsync();
        }
    }
}