using ComparaItens.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ComparaItens.Infra.Mapping
{
    public static class MapCharacteristicKeyContext
    {
        public static void MapCharacteristicKey(this DataContext context, ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CharacteristicKey>().ToTable("tabCharacteristicKey");

            modelBuilder.Entity<CharacteristicKey>().Property(x => x.Id).HasColumnType("int(11)");
            modelBuilder.Entity<CharacteristicKey>().Property(x => x.Id).HasColumnName("id");
            modelBuilder.Entity<CharacteristicKey>().HasKey(x => x.Id);
            modelBuilder.Entity<CharacteristicKey>().HasIndex(x => x.Id);
            modelBuilder.Entity<CharacteristicKey>().Property(f => f.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<CharacteristicKey>().Property(x => x.CharacteristicId).HasColumnType("int(11)");
            modelBuilder.Entity<CharacteristicKey>().Property(x => x.CharacteristicId).HasColumnName("characteristicId");
            modelBuilder.Entity<CharacteristicKey>().HasIndex(x => x.CharacteristicId);

            modelBuilder.Entity<CharacteristicKey>().Property(x => x.Description).HasColumnType("varchar(100)");
            modelBuilder.Entity<CharacteristicKey>().Property(x => x.Description).HasColumnName("description");
            modelBuilder.Entity<CharacteristicKey>().Property(x => x.Description).IsRequired();

            // Relationships
            modelBuilder.Entity<CharacteristicKey>().HasOne(p => p.Characteristics).WithMany().HasForeignKey(f => f.CharacteristicId);
        }
    }
}