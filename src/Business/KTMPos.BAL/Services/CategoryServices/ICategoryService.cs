using KTMPos.Common.Dto;
using KTMPos.DAL.Entities;

namespace KTMPos.BAL.Services.CategoryServices
{
    public interface ICategoryService
    {
        Task SaveAsync(CategoryWriteDto category);
        Task DeleteAsync(int id);
        Task<List<CategoryReadDto>> GetAllAsync();
        Task UpdateAsync(CategoryWriteDto category);

    }
}
