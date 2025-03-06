using KTMPos.DAL.Entities;
using System.Globalization;

namespace KTMPos.DAL.Repository.CategoryRepository
{
    public interface ICategoryRepository
    {
        Task SaveAsync(Category category);
        Task DeleteAsync(int id);
        Task<List<Category>> GetAllAsync();
        Task UpdateAsync(int id,string name);
        Task<Category> GetByIdAsync(int id);   

    }
}
