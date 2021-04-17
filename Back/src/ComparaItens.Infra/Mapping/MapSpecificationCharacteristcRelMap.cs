using ComparaItens.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ComparaItens.Infra.Mapping
{
    public static class MapSpecificationCharacteristcRelMap
    {
        public static void MapSpecificationCharacteristcRel(this DataContext context, ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SpecificationCharacteristcRel>().ToTable("tabSpecificationCharacteristcRel");

            modelBuilder.Entity<SpecificationCharacteristcRel>().Property(x => x.SpecificationItemId).HasColumnType("int(11)");
            modelBuilder.Entity<SpecificationCharacteristcRel>().Property(x => x.SpecificationItemId).HasColumnName("specificationItemId");
            modelBuilder.Entity<SpecificationCharacteristcRel>().HasIndex(x => x.SpecificationItemId);

            modelBuilder.Entity<SpecificationCharacteristcRel>().Property(x => x.CharacteristicDescriptionId).HasColumnType("int(11)");
            modelBuilder.Entity<SpecificationCharacteristcRel>().Property(x => x.CharacteristicDescriptionId).HasColumnName("characteristicDescriptionId");
            modelBuilder.Entity<SpecificationCharacteristcRel>().HasIndex(x => x.CharacteristicDescriptionId);
            //modelBuilder.Entity<SpecificationCharacteristcRel>().HasNoKey();

            modelBuilder.Entity<SpecificationCharacteristcRel>().HasKey(c => new { c.SpecificationItemId, c.CharacteristicDescriptionId });

            // Relationships
            //modelBuilder.Entity<SpecificationCharacteristcRel>().HasOne(p => p.SpecificationItem).WithMany().HasForeignKey(f => f.SpecificationItemId);
           // modelBuilder.Entity<SpecificationCharacteristcRel>().HasOne(p => p.CharacteristicDescription).WithMany().HasForeignKey(f => f.CharacteristicDescriptionId);



        }
    }
}