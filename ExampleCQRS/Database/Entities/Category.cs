using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExampleCQRS.Database.Entities;

[Table("Categories")]
public class Category : BaseEntity
{
    [StringLength(200)]
    public string? Name { get; set; }

    public virtual ICollection<Product>? Products { get; set; }

}
