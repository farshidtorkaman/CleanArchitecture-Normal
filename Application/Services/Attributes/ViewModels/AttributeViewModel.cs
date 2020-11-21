using Application.Common.Mappings;
using Domain.Entities;
using Domain.Enums;

namespace Application.Services.Attributes.ViewModels
{
    public class AttributeViewModel : IMapFrom<Attribute>
    {
        public string Title { get; set; }

        public int AttributeGroupId { get; set; }

        public AttributeType AttributeType { get; set; }
    }
}