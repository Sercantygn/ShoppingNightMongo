using ShoppingNightMongo.Dtos.ProductDtos;

namespace ShoppingNightMongo.Services.ProductServices
{
    public interface IProductService
    {
        Task<List<ResultProductDto>> GetResultProductDtosAsync();
        Task CreateProductDto(CreateProductDto createProductDto);
        Task UpdateProductDto(UpdateProductDto updateProductDto);
        Task DeleteProductDto(string Id);

        Task<GetProductByIdDto> GetProductByIdAsync(string Id);
    }
}
