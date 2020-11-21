using Application.Common.Mappings;
using Domain.Entities;

namespace Application.Services.AttributeGroups.ViewModels
{
    public class AttributeGroupListViewModel : IMapFrom<AttributeGroup>
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string CategoryName { get; set; }
    }
}