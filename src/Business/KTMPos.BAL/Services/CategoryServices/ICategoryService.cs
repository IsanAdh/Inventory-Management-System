using KTMPos.Common.Dto;
using KTMPos.DAL.Entities;

namespace KTMPos.BAL.Services.CategoryServices
{
    public interface ICategoryService
    {
        Task<OutputDto> SaveAsync(CategoryInsertDto category);
        Task<OutputDto> DeleteAsync(int id);
        Task<DataOutputDto<CategoryReadDto>> GetAllAsync();
        Task<OutputDto> UpdateAsync(CategoryUpdateDto category);

    }
}
