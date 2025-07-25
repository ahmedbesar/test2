using Microsoft.EntityFrameworkCore;
using test2.Products;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace test2.EntityFrameworkCore;

[ConnectionStringName(test2DbProperties.ConnectionStringName)]
public interface Itest2DbContext : IEfCoreDbContext
{
     DbSet<Product> Products { get; }
}
