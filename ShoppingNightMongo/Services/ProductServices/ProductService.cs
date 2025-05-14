using ShoppingNightMongo.Dtos.ProductDtos;

namespace ShoppingNightMongo.Services.ProductServices
{
    public class ProductService : IProductService
    {
        public Task CreateProductDto(CreateProductDto createProductDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProductDto(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<GetProductByIdDto> GetProductByIdAsync(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultProductDto>> GetResultProductDtosAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateProductDto(UpdateProductDto updateProductDto)
        {
            throw new NotImplementedException();
        }
    }
}
