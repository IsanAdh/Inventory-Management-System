using KTMPos.Common.Dto;
using KTMPos.DAL.Entities;

namespace KTMPos.BAL.Services.CategoryServices
{
    public interface ICategoryService
    {
        Task SaveAsync(CategoryInsertDto category);
        Task DeleteAsync(int id);
        Task<List<CategoryReadDto>> GetAllAsync();
        Task UpdateAsync(CategoryUpdateDto category);

    }
}
