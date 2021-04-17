using ComparaItens.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ComparaItens.Infra.Mapping
{
    public static class MapProductItemContext
    {
        public static void MapProductItem(this DataContext context, ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductItem>().ToTable("tabProdutItem");

            modelBuilder.Entity<ProductItem>().Property(x => x.ProductId).HasColumnType("int(11)");
            modelBuilder.Entity<ProductItem>().Property(x => x.ProductId).HasColumnName("productId");
            modelBuilder.Entity<ProductItem>().HasIndex(x => x.ProductId);

            modelBuilder.Entity<ProductItem>().Property(x => x.CharacteristicDescriptionId).HasColumnType("int(11)");
            modelBuilder.Entity<ProductItem>().Property(x => x.CharacteristicDescriptionId).HasColumnName("characteristicDescriptionId");
            modelBuilder.Entity<ProductItem>().HasIndex(x => x.CharacteristicDescriptionId);

            modelBuilder.Entity<ProductItem>().HasKey(c => new { c.ProductId, c.CharacteristicDescriptionId });

            //RelationShip
            modelBuilder.Entity<ProductItem>().HasOne(p => p.CharacteristicDescription).WithMany().HasForeignKey(f => f.CharacteristicDescriptionId);
            modelBuilder.Entity<ProductItem>().HasOne(p => p.Product).WithMany().HasForeignKey(f => f.ProductId);
        }
    }
}