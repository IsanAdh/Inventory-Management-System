using KTMPos.Common.Dto;
using KTMPos.DAL.Repository.CategoryRepository;
using KTMPos.DAL.Entities;
using KTMPos.Common.Utilities;
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
                        CreatedBy= x.CreatedUser.UserName,
                        CreatedDate=x.CreatedDate.Value.FormatDate(),
                        LastModifiedBy=x.ModifiedUser?.UserName,
                        LastModifiedDate=x.LastModifiedDate,
                    }).ToList();
        }

        public async Task SaveAsync(CategoryInsertDto request)
        {
            var category = new Category
            {
                //Id = request.Id, save garna Id ko need hudaina Database le aafai Id lai manage garcha
                Name = request.Name,
                CreatedBy = request.CreatedBy,
            };
            await _categoryRepository.SaveAsync(category);
        }

        public async Task UpdateAsync(CategoryUpdateDto updateDto)
        {
            var category = new Category
            {
                Id = updateDto.Id,
                Name = updateDto.Name,
                LastModifiedBy = updateDto.CreatedBy,
                LastModifiedDate = DateTime.Now,
            };
            await _categoryRepository.UpdateAsync(category);
        }
    }
}
