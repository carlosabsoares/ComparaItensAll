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
        private CharacteristicDescriptionRepository productItem;

        public ProductRepository(DataContext context)
        {
            _context = context;
            productItem = new CharacteristicDescriptionRepository(_context);
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
            var _return = await _context.Products.AsNoTracking()
                .Include(x => x.Category)
                .Include(x => x.Manufecturer)
                .ToListAsync();

            foreach (var item in _return)
            {
                item.CharacteristicDescriptions = await productItem.FindByProductId(item.Id);
            }

            return _return;
        }

        public async Task<Product> FindById(int id)
        {
            var _return = await _context.Products.AsNoTracking()
                .Include(x => x.Category)
                .Include(x => x.Manufecturer)
                .Where(x => x.Id == id).ToListAsync();

            foreach (var item in _return)
            {
                item.CharacteristicDescriptions = await productItem.FindByProductId(item.Id);
            }

            return _return.FirstOrDefault();
        }

        public async Task<IList<Product>> FindByParameters(int categoryId,
                                                           int manufacturerId,
                                                           int characteisticId,
                                                           string key,
                                                           string keyDescription,
                                                           string description)
        {
            var query = await _context.Products.AsNoTracking()
                                                  .Include(x => x.Category)
                                                  .Include(x => x.Manufecturer)
                                                  .ToListAsync();

            if (categoryId > 0)
                query = query.Where(x => x.CategoryId == categoryId).ToList();

            if (manufacturerId > 0)
                query = query.Where(x => x.ManufecturerId == manufacturerId).ToList();

            foreach (var item in query)
            {
                item.CharacteristicDescriptions = await productItem.FindByProductId(item.Id);
            }

            if (characteisticId > 0)
                query = query.Where(x =>
                    x.CharacteristicDescriptions.Any(i => i.Characteristics.Id == characteisticId)).ToList();

            if (!string.IsNullOrEmpty(key))
                query = query.Where(x =>
                    x.CharacteristicDescriptions.Any(i => i.CharacteristicKeys.Key.ToLower().Contains(key.ToLower()))).ToList();

            if (!string.IsNullOrEmpty(description))
                query = query.Where(x =>
                    x.CharacteristicDescriptions.Any(i => i.CharacteristicKeys.Description.ToLower().Contains(keyDescription.ToLower()))).ToList();

            if (!string.IsNullOrEmpty(description))
                query = query.Where(x =>
                    x.CharacteristicDescriptions.Any(i => i.Characteristics.Description.ToLower().Contains(description.ToLower()))).ToList();

            return query;
        }
    }
}