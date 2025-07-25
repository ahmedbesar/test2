using System;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.EventBus.Distributed;

namespace test2.Products.Events;

public class OrderEventHandler : IDistributedEventHandler<OrderPlacedEto>,
    ITransientDependency
{
    private readonly IRepository<Product, Guid> _productRepository;

    public OrderEventHandler(IRepository<Product, Guid> productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task HandleEventAsync(OrderPlacedEto eventData)
    {
        var product = await _productRepository.FindAsync(eventData.ProductId);
        if (product == null)
        {
            return;
        }

        product.StockCount = product.StockCount - 1;

        await _productRepository.UpdateAsync(product);
    }
}