using ComparaItens.Domain.Entities;
using ComparaItens.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
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
            try
            {
                Product product = new Product();
                product.Folder = entity.Folder;
                product.CategoryId = entity.CategoryId;
                product.Description = entity.Description;
                product.Image = entity.Image;
                product.ManufacturerId = entity.ManufacturerId;
                product.YearOfManufacture = entity.YearOfManufacture;
                product.Model = entity.Model;

                _context.Add(product);
                _context.SaveChanges();

                if (entity.CharacteristicDescriptions.Count > 0)
                {
                    foreach (var item in entity.CharacteristicDescriptions)
                    {
                        CharacteristicDescription characteristicDescription = new CharacteristicDescription();

                        characteristicDescription.ProductId = product.Id;
                        characteristicDescription.CharacteristicId = item.CharacteristicId;
                        characteristicDescription.CharacteristicKeyId = item.CharacteristicKeyId;

                        _context.Add(characteristicDescription);
                    }
                }

                _context.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public async Task<bool> Delete(Product entity)
        {
            try
            {
                Product product = new Product();
                product.Folder = entity.Folder;
                product.CategoryId = entity.CategoryId;
                product.Description = entity.Description;
                product.Image = entity.Image;
                product.ManufacturerId = entity.ManufacturerId;
                product.YearOfManufacture = entity.YearOfManufacture;
                product.Model = entity.Model;

                _context.Remove(product);
                _context.SaveChanges();

                var _result = productItem.FindByProductId(entity.Id);

                _context.Remove(_result);

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
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
                query = query.Where(x => x.ManufacturerId == manufacturerId).ToList();

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

        public async Task<bool> Update(Product entity)
        {
            try
            {
                Product product = new Product();
                product.Id = entity.Id;
                product.Folder = entity.Folder;
                product.CategoryId = entity.CategoryId;
                product.Description = entity.Description;
                product.Image = entity.Image;
                product.ManufacturerId = entity.ManufacturerId;
                product.YearOfManufacture = entity.YearOfManufacture;
                product.Model = entity.Model;

                _context.Update(product);
                _context.SaveChanges();
                
                var _result = await productItem.FindByProductId(entity.Id);

                if (_result.Count > 0)
                {
                    foreach (var item in _result)
                    {
                        CharacteristicDescription characteristicDescription = new CharacteristicDescription();

                         characteristicDescription.ProductId = product.Id;
                        characteristicDescription.CharacteristicId = item.CharacteristicId;
                        characteristicDescription.CharacteristicKeyId = item.CharacteristicKeyId;

                        _context.Remove(characteristicDescription);
                    }
                }

                if (entity.CharacteristicDescriptions.Count > 0)
                {
                    foreach (var item in entity.CharacteristicDescriptions)
                    {
                        CharacteristicDescription characteristicDescription = new CharacteristicDescription();

                        characteristicDescription.ProductId = product.Id;
                        characteristicDescription.CharacteristicId = item.CharacteristicId;
                        characteristicDescription.CharacteristicKeyId = item.CharacteristicKeyId;

                        _context.Add(characteristicDescription);
                    }
                }

                _context.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }
    }
}