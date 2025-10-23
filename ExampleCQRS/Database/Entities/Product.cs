using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace ExampleCQRS.Database.Entities;

[Table("Products")]
public class Product : BaseEntity
{
    [ForeignKey("CategoryId")]
    public int CategoryId { get; set; }

    public virtual Category? Category { get; set; }

    [StringLength(500)]
    public string? Title { get; set; }

    [StringLength(int.MaxValue)]
    public string? Description { get; set; }

    [NotNull]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }

    public int Stock { get; set; }

    [AllowNull]
    [StringLength(200)]
    public string? Color { get; set; }

    public bool IsPromoted { get; set; }
}
