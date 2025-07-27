using AutoMapper;
using BooklyBookStoreApp.Application.DTOs.BookDtos;
using BooklyBookStoreApp.Application.DTOs.CategoryDtos;
using BooklyBookStoreApp.Application.Exceptions;
using BooklyBookStoreApp.Application.Services;
using BooklyBookStoreApp.Domain.Entitites;
using BooklyBookStoreApp.Domain.Repositories;
using Microsoft.EntityFrameworkCore;


namespace BooklyBookStoreApp.Persistence.Services
{
    public class CategoryService(IRepositoryManager repositoryManager, IMapper mapper) : ICategoryService
    {
        public async Task<CategoryDto> CreateCategoryAsync(CreateCategoryDto createCategoryDto)
        {
            var category = mapper.Map<Category>(createCategoryDto);
            repositoryManager.Category.Create(category);
            await repositoryManager.Save();
            return mapper.Map<CategoryDto>(category);

        }

        public Task DeleteCategoryAsync(int id, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<GetAllCategoriesDto>> GetAllCategoriesAsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<GetOneCategoryByIdDto> GetOneCategoryByIdAsync(int id, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCategoryAsync(int id, UpdateCategoryDto updateCategoryDto, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        private async Task<Category> CheckCategoryExist(int id, bool trackChanges)
        {
            var category = await repositoryManager.Category.GetOneCategoryById(id, trackChanges).FirstOrDefaultAsync();
            if (category is null)
            {
                throw new CategoryNotFoundException(id);
            }
            return category;

        }

    }
}
