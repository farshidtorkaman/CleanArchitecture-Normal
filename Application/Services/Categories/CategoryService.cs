using Application.Common.Interfaces;
using Application.Repositories;
using Application.Services.Categories.ViewModels;
using AutoMapper;
using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Services.Categories
{
    internal class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public CategoryService(ICategoryRepository categoryRepository,
                               IMapper mapper,
                               IUnitOfWork unitOfWork)
        {
            _categoryRepository = categoryRepository;

            _mapper = mapper;

            _unitOfWork = unitOfWork;
        }

        public async Task Add(CategoryViewModel category)
        {
            _categoryRepository.Add(new Category
            {
                Name = category.Name,

                ParentId = category.ParentId
            });

            await _unitOfWork.CompleteAsync();
        }

        public async Task<IEnumerable<CategoryViewModel>> GetAsQueryable()
        {
            var model = await _categoryRepository.GetAllAsync();

            return _mapper.Map<IEnumerable<CategoryViewModel>>(model);
        }

        public async Task<IEnumerable<CategoryListViewModel>> ListAsync()
        {
            var model = await _categoryRepository.GetAllAsync();

            return _mapper.Map<IEnumerable<CategoryListViewModel>>(model);
        }
    }
}