using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper.Internal.Mappers;
using test2.Products.Manager;
using Volo.Abp.Domain.Repositories;

namespace test2.Products;

public class ProductAppService : test2AppService, IProductAppService
{
    private readonly IRepository<Product, Guid> _productRepository;
    private readonly ProductManager  _productManager;
    public ProductAppService(IRepository<Product, Guid> productRepository,ProductManager productManager)
    {
        _productRepository = productRepository;
        _productManager = productManager;
    }
    public async Task<List<ProductDto>> GetListAsync()
    {
        var products = await _productRepository.GetListAsync();
        return ObjectMapper.Map<List<Product>, List<ProductDto>>(products);
    }
    public async Task CreateAsync(ProductCreationDto input)
    {
        var product = Product.Create(input.Name,input.StockCount);
        await _productManager.InsertProductAsync(product);
    }
}