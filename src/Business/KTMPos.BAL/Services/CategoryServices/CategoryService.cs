using KTMPos.Common.Dto;
using KTMPos.DAL.Repository.CategoryRepository;
using KTMPos.DAL.Entities;
namespace KTMPos.BAL.Services.CategoryServices
{
    internal class CategoryService : ICategoryService      
    {
        private readonly ICategoryRepository _categoryRepository; 
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public async Task DeleteAsync(int id)
        {
           await _categoryRepository.DeleteAsync(id);
        }

        public async Task<List<CategoryReadDto>> GetAllAsync()
        {
            var catagories= await _categoryRepository.GetAllAsync();
            return catagories
                    .Select(x=>new CategoryReadDto
                    {
                        Id = x.Id,
                        Name = x.Name,
                    }).ToList();
        }

        public async Task SaveAsync(CategoryWriteDto request)
        {
            var category = new Category
            {
                //Id = request.Id, save garna Id ko need hudaina Database le aafai Id lai manage garcha
                Name = request.Name,
            };
            await _categoryRepository.SaveAsync(category);
        }

        public async Task UpdateAsync(CategoryWriteDto category)
        {
            await _categoryRepository.UpdateAsync(category.Id,category.Name);
        }
    }
}
