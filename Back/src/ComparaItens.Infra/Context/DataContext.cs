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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            this.MapCategory(modelBuilder);
            this.MapProduct(modelBuilder);
            this.MapManufacturer(modelBuilder);
            this.MapSpecificationItem(modelBuilder);
            this.MapUser(modelBuilder);
        }
    }
}