using System;
using System.Threading.Tasks;
using test2.Products.Events;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.EventBus.Distributed;

namespace test2.Products.EventHandlers;

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

        product.DecreaseStock();
        await _productRepository.UpdateAsync(product);
    }
}