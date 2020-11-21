using Application.Common.Mappings;
using Domain.Entities;

namespace Application.Services.Categories.ViewModels
{
    public class CategoryViewModel : IMapFrom<Category>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int? ParentId { get; set; }
    }
}