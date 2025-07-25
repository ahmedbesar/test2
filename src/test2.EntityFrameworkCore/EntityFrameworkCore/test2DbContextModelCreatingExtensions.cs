using Microsoft.EntityFrameworkCore;
using test2.Products;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace test2.EntityFrameworkCore;

public static class test2DbContextModelCreatingExtensions
{
    public static void Configuretest2(
        this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));

        builder.Entity<Product>(b =>
        {
            b.ToTable("Products");

            b.ConfigureByConvention();

            b.Property(q => q.Name).IsRequired().HasMaxLength(100);
        });
        
  
    }
}
