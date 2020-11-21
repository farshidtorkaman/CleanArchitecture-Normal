using Application.Services.AttributeGroups.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Services.AttributeGroups
{
    public interface IAttributeGroupService
    {
        Task<IEnumerable<AttributeGroupViewModel>> GetAsQueryable();

        Task<IEnumerable<AttributeGroupListViewModel>> ListAsync();

        Task Add(AttributeGroupViewModel attributeGroup);
    }
}