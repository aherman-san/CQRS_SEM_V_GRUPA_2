using ExampleCQRS.Database.Entities;
using ExampleCQRS.DTOS;

namespace ExampleCQRS.Mappers
{
    public static class DtoMapper
    {
        public static SimpleProductDto ToSimpleProductDto(this Product product)
        {
            return new SimpleProductDto
            {
                Id = product.Id,
                Title = product.Title != null ? product.Title : string.Empty,
                DisplayPrice = $"{product.Price} zł"
            };
        }

        public static FullProductDto ToFullProductDto(this Product product)
        {
            return new FullProductDto
            {
                Id = product.Id,
                Title = product.Title != null ? product.Title : string.Empty,
                DisplayPrice = $"{product.Price} zł",
                Description = product.Description != null ? product.Description : string.Empty,
                ShortDescription = product.Description != null ? $"{product.Description.Substring(0, 100)} ..." : string.Empty,
                Price = product.Price,
                Color = product.Color,
                Category = product.Category!.Name!
            };
        }

        public static CategoryDto ToCategoryDto(this Category category)
        {
            return new CategoryDto
            {
                Id = category.Id,
                Name = category.Name != null ? category.Name : string.Empty,
            };
        }
    }
}