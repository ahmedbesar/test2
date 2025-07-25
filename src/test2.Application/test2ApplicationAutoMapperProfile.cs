using AutoMapper;
using test2.Products;
using Volo.Abp.AutoMapper;

namespace test2;

public class test2ApplicationAutoMapperProfile : Profile
{
    public test2ApplicationAutoMapperProfile()
    {
        CreateMap<Product, ProductDto>();
    }
}
