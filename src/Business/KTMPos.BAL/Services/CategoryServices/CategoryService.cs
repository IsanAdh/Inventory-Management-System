using KTMPos.Common.Dto;
using KTMPos.DAL.Repository.CategoryRepository;
using KTMPos.DAL.Entities;
using KTMPos.Common.Utilities;
using KTMPos.Common.Enums;
using KTMPos.Common.Constants;
using System.Globalization;
namespace KTMPos.BAL.Services.CategoryServices
{
    internal class CategoryService : ICategoryService      
    {
        private readonly ICategoryRepository _categoryRepository; 
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public async Task<OutputDto> DeleteAsync(int id)
        {
            try
            {
                await _categoryRepository.DeleteAsync(id);
                return OutputDtoConverter.SetOutputDto(Status.Success, "Category deleted successfully.");      
            }
            catch (Exception ex)
            {
                return OutputDtoConverter.SetOutputDto(Status.Fail,Message.Failed,new List<string> { ex.Message});
            }
        }



        public async Task<DataOutputDto<CategoryReadDto>> GetAllAsync()
        {
            try
            {
                var result = await _categoryRepository.GetAllAsync();
                var catagories = result
                                 .Select(x => new CategoryReadDto
                                 {
                                     Id = x.Id,
                                     Name = x.Name,
                                     CreatedBy = x.CreatedUser.UserName,
                                     CreatedDate = x.CreatedDate.Value.FormatDate(),
                                     LastModifiedBy = x.ModifiedUser?.UserName,
                                     LastModifiedDate = x.LastModifiedDate,
                                 }).ToList();
                return OutputDtoConverter.SetDataOutputDto(Status.Success, Message.Success, catagories);
            }
            catch (Exception ex)
            {

                return OutputDtoConverter.SetDataOutputDto(Status.Success, Message.Success,new List<CategoryReadDto>(), new List<string> { ex.Message});

            }
        }

        public async Task<OutputDto> SaveAsync(CategoryInsertDto request)
        {
            try
            {
                var category = new Category
                {
                    //Id = request.Id, save garna Id ko need hudaina Database le aafai Id lai manage garcha
                    Name = request.Name,
                    CreatedBy = request.CreatedBy,
                };
                await _categoryRepository.SaveAsync(category);
                return OutputDtoConverter.SetOutputDto(Status.Success, "Category saved Successfully");
            }
            catch ( Exception ex)
            {

                return OutputDtoConverter.SetOutputDto(Status.Fail, Message.Failed, new List<string> { ex.Message });
                
            }
        }

        public async Task<OutputDto> UpdateAsync(CategoryUpdateDto updateDto)
        {
            try
            {
                var category = new Category
                {
                    Id = updateDto.Id,
                    Name = updateDto.Name,
                    LastModifiedBy = updateDto.CreatedBy,
                    LastModifiedDate = DateTime.Now,
                };
                await _categoryRepository.UpdateAsync(category);
                return OutputDtoConverter.SetOutputDto(Status.Success, "Category updated successfully.");
            }
            catch (Exception ex)
            {

                return OutputDtoConverter.SetOutputDto(Status.Fail, Message.Failed, new List<string> { ex.Message });
            }
        }
    }
}
