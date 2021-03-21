using ComparaItens.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ComparaItens.Infra.Mapping
{
    public static class MapManufacturerContext
    {
        public static void MapManufacturer(this DataContext context, ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Manufacturer>().ToTable("tabManufacturer");

            modelBuilder.Entity<Manufacturer>().Property(x => x.Id).HasColumnType("int(11)");
            modelBuilder.Entity<Manufacturer>().Property(x => x.Id).HasColumnName("id");
            modelBuilder.Entity<Manufacturer>().HasKey(x => x.Id);
            modelBuilder.Entity<Manufacturer>().HasIndex(x => x.Id);
            modelBuilder.Entity<Manufacturer>().Property(f => f.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<Manufacturer>().Property(x => x.Description).HasColumnType("varchar(150)");
            modelBuilder.Entity<Manufacturer>().Property(x => x.Description).HasColumnName("description");
            modelBuilder.Entity<Manufacturer>().Property(x => x.Description).IsRequired();
        }
    }
}