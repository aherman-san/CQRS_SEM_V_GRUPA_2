using ExampleCQRS.DTOS;

namespace ExampleCQRS.Services
{
    public interface IProductService
    {
        Task<SimpleProductDto[]> GetPromotedProducts();
    }
}
