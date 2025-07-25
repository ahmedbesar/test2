using System.ComponentModel.DataAnnotations;

namespace test2.Products;

public class ProductCreationDto
{
    [Required]
    [StringLength(100)]
    public string Name { get; set; }

    [Range(0, int.MaxValue)]
    public int StockCount { get; set; }
}