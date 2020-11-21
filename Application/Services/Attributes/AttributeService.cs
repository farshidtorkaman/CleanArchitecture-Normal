using Application.Common.Interfaces;
using Application.Repositories;
using Application.Services.Attributes.ViewModels;
using AutoMapper;
using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Services.Attributes
{
    internal class AttributeService : IAttributeService
    {
        private readonly IAttributeRepository _attributeRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public AttributeService(IAttributeRepository attributeRepository,
                                IMapper mapper,
                                IUnitOfWork unitOfWork)
        {
            _attributeRepository = attributeRepository;

            _mapper = mapper;

            _unitOfWork = unitOfWork;
        }

        public async Task AddAsync(AttributeViewModel attribute)
        {
            var model = _mapper.Map<Attribute>(attribute);

            _attributeRepository.Add(model);

            await _unitOfWork.CompleteAsync();
        }

        public async Task<IEnumerable<AttributeListViewModel>> ListAsync()
        {
            var model = await _attributeRepository.GetAllAsync();

            return _mapper.Map<IEnumerable<AttributeListViewModel>>(model);
        }
    }
}