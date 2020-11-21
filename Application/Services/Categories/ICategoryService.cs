using Application.Services.Categories.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Services.Categories
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryListViewModel>> ListAsync();

        Task Add(CategoryViewModel category);

        Task<IEnumerable<CategoryViewModel>> GetAsQueryable();
    }
}