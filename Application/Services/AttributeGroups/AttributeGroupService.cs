using Application.Common.Interfaces;
using Application.Repositories;
using Application.Services.AttributeGroups.ViewModels;
using AutoMapper;
using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Services.AttributeGroups
{
    internal class AttributeGroupService : IAttributeGroupService
    {
        private readonly IAttributeGroupRepository _attributeGroupRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public AttributeGroupService(IAttributeGroupRepository attributeGroupRepository,
                                     IMapper mapper,
                                     IUnitOfWork unitOfWork)
        {
            _attributeGroupRepository = attributeGroupRepository;

            _mapper = mapper;

            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<AttributeGroupListViewModel>> ListAsync()
        {
            var model = await _attributeGroupRepository.GetAllAsync();

            return _mapper.Map<IEnumerable<AttributeGroupListViewModel>>(model);
        }

        public async Task Add(AttributeGroupViewModel attributeGroup)
        {
            var model = _mapper.Map<AttributeGroup>(attributeGroup);

            _attributeGroupRepository.Add(model);

            await _unitOfWork.CompleteAsync();
        }

        public async Task<IEnumerable<AttributeGroupViewModel>> GetAsQueryable()
        {
            var model = await _attributeGroupRepository.GetAllAsync();

            return _mapper.Map<IEnumerable<AttributeGroupViewModel>>(model);
        }
    }
}