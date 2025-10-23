using ExampleCQRS.Database;
using ExampleCQRS.DTOS;
using ExampleCQRS.Mappers;
using Microsoft.EntityFrameworkCore;

namespace ExampleCQRS.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ShopContext _dbContext;

        public CategoryService(ShopContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<CategoryDto[]> GetCategoriesAsync()
        {
            //var listaKategorii = await _dbContext.Categories.ToListAsync();
            //var listakategoriiiDto = listaKategorii.Select(k => k.ToCategoryDto());
            //var listakategoriiiDtoAlfabetycznie = listakategoriiiDto.OrderBy(k => k.Name);
            //return listakategoriiiDtoAlfabetycznie.ToArray();

            return await _dbContext
                .Categories.OrderBy(c => c.Name)
                .Select(c => c.ToCategoryDto())
                .ToArrayAsync(); 
        }
    }
}
