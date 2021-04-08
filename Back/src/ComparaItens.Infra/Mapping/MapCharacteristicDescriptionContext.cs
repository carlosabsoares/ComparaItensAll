using ComparaItens.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparaItens.Infra
{
    public static class MapCharacteristicDescriptionContext
    {
        public static void MapCharacteristicDescription(this DataContext context, ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CharacteristicDescription>().ToTable("tabCharacteristicDescription");

            modelBuilder.Entity<CharacteristicDescription>().Property(x => x.Id).HasColumnType("int(11)");
            modelBuilder.Entity<CharacteristicDescription>().Property(x => x.Id).HasColumnName("id");
            modelBuilder.Entity<CharacteristicDescription>().HasKey(x => x.Id);
            modelBuilder.Entity<CharacteristicDescription>().HasIndex(x => x.Id);
            modelBuilder.Entity<CharacteristicDescription>().Property(f => f.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<CharacteristicDescription>().Property(x => x.CharacteristicId).HasColumnType("int(11)");
            modelBuilder.Entity<CharacteristicDescription>().Property(x => x.CharacteristicId).HasColumnName("characteristicId");
            modelBuilder.Entity<CharacteristicDescription>().HasIndex(x => x.CharacteristicId);

            modelBuilder.Entity<CharacteristicDescription>().Property(x => x.ProductId).HasColumnType("int(11)");
            modelBuilder.Entity<CharacteristicDescription>().Property(x => x.ProductId).HasColumnName("productId");
            modelBuilder.Entity<CharacteristicDescription>().HasIndex(x => x.ProductId);

            modelBuilder.Entity<CharacteristicDescription>().Property(x => x.CharacteristicKeyId).HasColumnType("int(11)");
            modelBuilder.Entity<CharacteristicDescription>().Property(x => x.CharacteristicKeyId).HasColumnName("characteristicKeyId");
            modelBuilder.Entity<CharacteristicDescription>().HasIndex(x => x.CharacteristicKeyId);

            // Relationships
            modelBuilder.Entity<CharacteristicDescription>().HasOne(p => p.Characteristics).WithMany().HasForeignKey(f => f.CharacteristicId);
            modelBuilder.Entity<CharacteristicDescription>().HasOne(p => p.CharacteristicKeys).WithMany().HasForeignKey(f => f.CharacteristicKeyId);
        }
    }
}
