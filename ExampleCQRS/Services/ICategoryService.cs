using ExampleCQRS.DTOS;

namespace ExampleCQRS.Services
{
    public interface ICategoryService
    {
        Task<CategoryDto[]> GetCategoriesAsync();
    }
}
