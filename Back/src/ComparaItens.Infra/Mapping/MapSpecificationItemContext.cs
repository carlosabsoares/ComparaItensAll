using ComparaItens.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ComparaItens.Infra.Mapping
{
    public static class MapSpecificationItemContext
    {
        public static void MapSpecificationItem(this DataContext context, ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SpecificationItem>().ToTable("tabSpecificationItems");

            modelBuilder.Entity<SpecificationItem>().Property(x => x.Id).HasColumnType("int(11)");
            modelBuilder.Entity<SpecificationItem>().Property(x => x.Id).HasColumnName("id");
            modelBuilder.Entity<SpecificationItem>().HasKey(x => x.Id);
            modelBuilder.Entity<SpecificationItem>().Property(f => f.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<SpecificationItem>().Property(x => x.ProductId).HasColumnType("int(11)");
            modelBuilder.Entity<SpecificationItem>().Property(x => x.ProductId).HasColumnName("ProductId");

            // Relationships
            modelBuilder.Entity<SpecificationItem>().HasMany(p => p.SpecificationCharacteristcRels).WithOne().HasForeignKey(f => f.SpecificationItemId);
        }
    }
}