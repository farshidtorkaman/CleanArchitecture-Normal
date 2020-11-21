using AutoMapper;

namespace Application.Common.Mappings
{
    internal interface IMapFrom<TEntity>
    {
        void Mapping(Profile profile) => profile.CreateMap(typeof(TEntity), GetType());
    }
}