using Application.Common.Mappings;
using AutoMapper;
using Domain.Entities;

namespace Application.Services.Attributes.ViewModels
{
    public class AttributeListViewModel : IMapFrom<Attribute>
    {
        public string Title { get; set; }

        public string AttributeGroupTitle { get; set; }

        public string AttributeType { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Attribute, AttributeListViewModel>()
                .ForMember(destination => destination.AttributeType, options => options.MapFrom(source => source.AttributeType.ToString()));
        }
    }
}