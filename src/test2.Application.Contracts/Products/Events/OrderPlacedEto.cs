using System;
using Volo.Abp.EventBus;

namespace test2.Products.Events;

[EventName("OrderCreated")]
public class OrderPlacedEto
{
    public string CustomerName { get; set; }
    public Guid ProductId { get; set; }
}