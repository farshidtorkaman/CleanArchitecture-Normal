using Application.Common.Mappings;
using Domain.Entities;

namespace Application.Services.Categories.ViewModels
{
    public class CategoryListViewModel : IMapFrom<Category>
    {
        public string Name { get; set; }
    }
}