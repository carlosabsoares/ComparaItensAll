using ComparaItens.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ComparaItens.Infra.Mapping
{
    public static class MapProductContext
    {
        public static void MapProduct(this DataContext context, ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("tabProdut");

            modelBuilder.Entity<Product>().Property(x => x.Id).HasColumnType("int(11)");
            modelBuilder.Entity<Product>().Property(x => x.Id).HasColumnName("id");
            modelBuilder.Entity<Product>().HasKey(x => x.Id);
            modelBuilder.Entity<Product>().HasIndex(x => x.Id);
            modelBuilder.Entity<Product>().Property(f => f.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<Product>().Property(x => x.Description).HasColumnType("varchar(150)");
            modelBuilder.Entity<Product>().Property(x => x.Description).HasColumnName("description");
            modelBuilder.Entity<Product>().Property(x => x.Description).IsRequired();

            modelBuilder.Entity<Product>().Property(x => x.ManufecturerId).HasColumnType("int(11)");
            modelBuilder.Entity<Product>().Property(x => x.ManufecturerId).HasColumnName("manufecturerId");
            modelBuilder.Entity<Product>().Property(x => x.ManufecturerId).IsRequired();

            modelBuilder.Entity<Product>().Property(x => x.Model).HasColumnType("varchar(150)");
            modelBuilder.Entity<Product>().Property(x => x.Model).HasColumnName("model");

            modelBuilder.Entity<Product>().Property(x => x.CategoryId).HasColumnType("int(11)");
            modelBuilder.Entity<Product>().Property(x => x.CategoryId).HasColumnName("categoryId");
            modelBuilder.Entity<Product>().Property(x => x.CategoryId).IsRequired();

            modelBuilder.Entity<Product>().Property(x => x.YearOfManufacture).HasColumnType("int(11)");
            modelBuilder.Entity<Product>().Property(x => x.YearOfManufacture).HasColumnName("yearOfManufacture");

            modelBuilder.Entity<Product>().Property(x => x.Image).HasColumnType("varchar(250)");
            modelBuilder.Entity<Product>().Property(x => x.Image).HasColumnName("image");

            modelBuilder.Entity<Product>().Property(x => x.Folder).HasColumnType("varchar(250)");
            modelBuilder.Entity<Product>().Property(x => x.Folder).HasColumnName("folder");

            // Relationships
            modelBuilder.Entity<Product>().HasOne(p => p.Manufecturer).WithMany().HasForeignKey(f => f.ManufecturerId);
            modelBuilder.Entity<Product>().HasOne(p => p.Category).WithMany().HasForeignKey(f => f.CategoryId);

        }
    }
}