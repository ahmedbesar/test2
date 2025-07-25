using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;

namespace test2.Products;

[Area(test2RemoteServiceConsts.ModuleName)]
[RemoteService(Name = test2RemoteServiceConsts.RemoteServiceName)]
[Route("api/test2/product")]
public class ProductController : test2Controller,IProductAppService
{
private readonly IProductAppService _productAppService;
    public ProductController(IProductAppService productAppService)
    {
        _productAppService = productAppService;
    }
    [HttpGet]
    [Route("GetAllProducts")]
    //[Authorize]
    public Task<List<ProductDto>> GetListAsync()
    {
        return _productAppService.GetListAsync();
    }
    [HttpPost]
    [Route("CreateProduct")]
    //[Authorize]
    public Task CreateAsync(ProductCreationDto input)
    {
        return _productAppService.CreateAsync(input);
    }
}