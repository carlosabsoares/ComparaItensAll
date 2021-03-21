using ComparaItens.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ComparaItens.Infra
{
    public static class MapCategoryContext
    {
        public static void MapCategory(this DataContext context, ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().ToTable("tabCategory");

            modelBuilder.Entity<Category>().Property(x => x.Id).HasColumnType("int(11)");
            modelBuilder.Entity<Category>().Property(x => x.Id).HasColumnName("id");
            modelBuilder.Entity<Category>().HasKey(x => x.Id);
            modelBuilder.Entity<Category>().HasIndex(x => x.Id);
            modelBuilder.Entity<Category>().Property(f => f.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<Category>().Property(x => x.Description).HasColumnType("varchar(100)");
            modelBuilder.Entity<Category>().Property(x => x.Description).HasColumnName("description");
            modelBuilder.Entity<Category>().Property(x => x.Description).IsRequired();
        }
    }
}