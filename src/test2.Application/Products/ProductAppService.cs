using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper.Internal.Mappers;
using Volo.Abp.Domain.Repositories;

namespace test2.Products;

public class ProductAppService : test2AppService, IProductAppService
{
    private readonly IRepository<Product, Guid> _productRepository;

    public ProductAppService(IRepository<Product, Guid> productRepository)
    {
        _productRepository = productRepository;
    }
    public async Task<List<ProductDto>> GetListAsync()
    {
        var products = await _productRepository.GetListAsync();
        return ObjectMapper.Map<List<Product>, List<ProductDto>>(products);
    }
    public async Task CreateAsync(ProductCreationDto input)
    {
        var product = new Product(input.Name, input.StockCount);
        await _productRepository.InsertAsync(product);
    }
}