using ShoppingNightMongo.Dtos.CategoryDtos;

namespace ShoppingNightMongo.Services.CategoryServices
{
    public interface ICategoryService
    {
        Task<List<ResultCategoryDto>> GetResultCategoryDtosAsync();
        Task CreateCategoryAsync(CreateCategoryDto createCategoryDto);
        Task UpdateCategoryDto(UpdateCategoryDto UpdateCategoryDto);
        Task DeleteCategoryDto(string id);
        Task<GetCategoryByIdDto> GetCategoryByIdAsync(string id);
    }
}
