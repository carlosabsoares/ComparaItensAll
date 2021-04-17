using ComparaItens.Domain.Entities;
using ComparaItens.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComparaItens.Infra.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DataContext _context;

        public ProductRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<bool> Add(Product entity)
        {
            Product product = new Product();
            product.Folder = entity.Folder;
            product.CategoryId = entity.CategoryId;
            product.Description = entity.Description;
            product.Image = entity.Image;
            product.ManufecturerId = entity.ManufecturerId;
            product.YearOfManufacture = entity.YearOfManufacture;
            product.Model = entity.Model;

            _context.Add(product);
            _context.SaveChanges();

            return (await _context.SaveChangesAsync()) > 0;
        }

        public async Task<IList<Product>> FindAll()
        {
            ProductItemRepository productItem = new ProductItemRepository(_context);

            var _return = await _context.Products.AsNoTracking()
                .Include(x => x.Category)
                .Include(x => x.Manufecturer)
                .ToListAsync();

            foreach (var item in _return)
            {
                item.ProductItems = await productItem.FindByProductId(item.Id);
            }

            return _return;
        }

        public async Task<Product> FindById(int id)
        {
            ProductItemRepository productItem = new ProductItemRepository(_context);

            var _return = await _context.Products.AsNoTracking()
                .Include(x => x.Category)
                .Include(x => x.Manufecturer)
                .Where(x => x.Id == id).ToListAsync();

            foreach (var item in _return)
            {
                item.ProductItems = await productItem.FindByProductId(item.Id);
            }

            return _return.FirstOrDefault();
        }

        public async Task<IList<Product>> FindByParameters(int categoryId,
                                                           int manufacturerId,
                                                           int characteisticId,
                                                           string key,
                                                           string description)
        {
            ProductItemRepository productItem = new ProductItemRepository(_context);

            var query = await _context.Products.AsNoTracking()
                                                  .Include(x => x.Category)
                                                  .Include(x => x.Manufecturer)
                                                  .ToListAsync();

            if (categoryId > 0)
                query = (List<Product>)query.Where(x => x.Category.Id == categoryId);

            if (manufacturerId > 0)
                query = (List<Product>)query.Where(x => x.ManufecturerId == manufacturerId);

            if (characteisticId > 0)
                query = (List<Product>)query.Where(x => x.Category.Id == characteisticId);

            foreach (var item in query)
            {
                item.ProductItems = await productItem.FindByProductId(item.Id);
            }

            if (!string.IsNullOrEmpty(key))
                _ = query.Where(x =>
                    x.ProductItems.Any(i => i.CharacteristicDescription.CharacteristicKeys.Key.Contains(key)));

            if (!string.IsNullOrEmpty(description))
                _ = query.Where(x =>
                    x.ProductItems.Any(i => i.CharacteristicDescription.CharacteristicKeys.Description.Contains(description)));

            return query;
        }
    }
}