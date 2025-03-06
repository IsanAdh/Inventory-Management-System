using KTMPos.DAL.Data;
using KTMPos.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace KTMPos.DAL.Repository.CategoryRepository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _context;
        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context; 
        }
        public async Task DeleteAsync(int id)
        {
            var category = await GetByIdAsync(id);
            _context.Remove(category);
           await _context.SaveChangesAsync();
        }

        public async Task<List<Category>> GetAllAsync()
        {
            var categories = await _context.Categories.AsNoTracking().OrderBy(x=>x.Id).ToListAsync();
            return categories;
        }

        public async Task<Category> GetByIdAsync(int id)
        {
           var catagory= await _context.Categories.FirstOrDefaultAsync(x=>x.Id == id);
            return catagory;
        }

        public async Task SaveAsync(Category category)
        {
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();  
        }

        public async Task UpdateAsync(int id,string name)
        {
            var category = await GetByIdAsync(id);
            category.Name = name;
            await _context.SaveChangesAsync();
        }
    }
}
