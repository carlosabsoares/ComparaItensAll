using ComparaItens.Domain.Entities;
using ComparaItens.Infra.Mapping;
using Microsoft.EntityFrameworkCore;

namespace ComparaItens.Infra
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Category> Categorys { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<SpecificationItem> SpecificationItems { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Characteristic> Characteristics { get; set; }
        public DbSet<CharacteristicKey> CharacteristicKeys { get; set; }
        public DbSet<CharacteristicDescription> CharacteristicDescriptions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            this.MapCategory(modelBuilder);
            this.MapProduct(modelBuilder);
            this.MapManufacturer(modelBuilder);
            this.MapSpecificationItem(modelBuilder);
            this.MapUser(modelBuilder);
            this.MapCharacteristic(modelBuilder);
            this.MapCharacteristicKey(modelBuilder);
            this.MapCharacteristicDescription(modelBuilder);
        }
    }
}