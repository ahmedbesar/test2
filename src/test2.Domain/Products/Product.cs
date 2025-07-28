using System;
using Volo.Abp;
using Volo.Abp.Domain.Entities;

namespace test2.Products;

public class Product : AggregateRoot<Guid>
{
    public string Name { get; set; }
    public int StockCount { get; private set; }

    public Product()
    {
        
    }

    private Product(string name,int stockCount)
    {
        Name = name;
        StockCount = stockCount;
    }
    public static Product Create(string name, int stockCount)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new BusinessException("Product name is required");

        if (stockCount < 0)
            throw new BusinessException("Stock count cannot be negative");

        return new Product(name, stockCount);
    }
    public void DecreaseStock()
    {
        if (StockCount <= 0)
        {
            throw new BusinessException("Quantity must be greater than zero.");
        }

        StockCount -= 1;
    }
}