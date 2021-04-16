using ComparaItens.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ComparaItens.Infra
{
    public static class MapCharacteristicContext
    {
        public static void MapCharacteristic(this DataContext context, ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Characteristic>().ToTable("tabCharacteristic");

            modelBuilder.Entity<Characteristic>().Property(x => x.Id).HasColumnType("int(11)");
            modelBuilder.Entity<Characteristic>().Property(x => x.Id).HasColumnName("id");
            modelBuilder.Entity<Characteristic>().HasKey(x => x.Id);
            modelBuilder.Entity<Characteristic>().HasIndex(x => x.Id);
            modelBuilder.Entity<Characteristic>().Property(f => f.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<Characteristic>().Property(x => x.Description).HasColumnType("varchar(100)");
            modelBuilder.Entity<Characteristic>().Property(x => x.Description).HasColumnName("description");
            modelBuilder.Entity<Characteristic>().Property(x => x.Description).IsRequired();
        }
    }
}