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

    public Product(string name,int stockCount)
    {
        Name = name;
        StockCount = stockCount;
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