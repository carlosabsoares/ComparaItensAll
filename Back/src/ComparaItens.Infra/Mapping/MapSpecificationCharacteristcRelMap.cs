using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            modelBuilder.Entity<SpecificationCharacteristcRel>().Property(x => x.SpecificationItemId).HasColumnName("id");
            modelBuilder.Entity<SpecificationCharacteristcRel>().HasKey(x => x.SpecificationItemId);
            modelBuilder.Entity<SpecificationCharacteristcRel>().HasIndex(x => x.SpecificationItemId);

            modelBuilder.Entity<SpecificationCharacteristcRel>().Property(x => x.CharacteristicDescriptionId).HasColumnType("int(11)");
            modelBuilder.Entity<SpecificationCharacteristcRel>().Property(x => x.CharacteristicDescriptionId).HasColumnName("id");
            modelBuilder.Entity<SpecificationCharacteristcRel>().HasKey(x => x.CharacteristicDescriptionId);
            modelBuilder.Entity<SpecificationCharacteristcRel>().HasIndex(x => x.CharacteristicDescriptionId);

        }



    }
}
