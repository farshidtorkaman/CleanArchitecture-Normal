using Application.Services.Attributes.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Services.Attributes
{
    public interface IAttributeService
    {
        Task<IEnumerable<AttributeListViewModel>> ListAsync();

        Task AddAsync(AttributeViewModel attribute);
    }
}