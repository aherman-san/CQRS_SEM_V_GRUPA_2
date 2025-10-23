using ExampleCQRS.Database.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace ExampleCQRS.DTOS
{
    public class FullProductDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ShortDescription { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string DisplayPrice { get; set; } = string.Empty;
        public string? Color { get; set; }
        public string Category { get; set; } = string.Empty;
    }
}
