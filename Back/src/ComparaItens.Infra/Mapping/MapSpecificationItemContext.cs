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

            modelBuilder.Entity<SpecificationItem>().Property(x => x.Description).HasColumnType("varchar(150)");
            modelBuilder.Entity<SpecificationItem>().Property(x => x.Description).HasColumnName("description");
            modelBuilder.Entity<SpecificationItem>().Property(x => x.Description).IsRequired();
            modelBuilder.Entity<SpecificationItem>().HasIndex(x => x.Description);

            // Relationships
            //modelBuilder.Entity<SpecificationItem>().HasOne(p => p.Product).WithMany().HasForeignKey(f => f.ProductId);
        }
    }
}