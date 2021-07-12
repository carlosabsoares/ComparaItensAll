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
        private readonly CharacteristicDescriptionRepository productItem;

        public ProductRepository(DataContext context)
        {
            _context = context;
            productItem = new CharacteristicDescriptionRepository(_context);
        }

        public async  Task<bool> Add(Product entity)
        {
            try
            {
                var product = new Product
                {
                    CategoryId = entity.CategoryId,
                    Description = entity.Description,
                    ManufacturerId = entity.ManufacturerId,
                    YearOfManufacture = entity.YearOfManufacture,
                    Model = entity.Model
                };

                _context.Add(product);
                _context.SaveChanges();

                if (entity.CharacteristicDescriptions.Count > 0)
                {
                    foreach (var item in entity.CharacteristicDescriptions)
                    {
                        var characteristicDescription = new CharacteristicDescription
                        {
                            ProductId = product.Id,
                            CharacteristicId = item.CharacteristicId,
                            CharacteristicKeyId = item.CharacteristicKeyId
                        };

                        _context.Add(characteristicDescription);
                    }
                }

                await _context.SaveChangesAsync();

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
                var _resultDescription = await productItem.FindByProductIdDelete(entity.Id);

                foreach (var item in _resultDescription)
                {
                    _context.Remove(item);
                    _context.SaveChanges();
                }

                _context.Remove(entity);
                _context.SaveChanges();

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
                                                           int characteristicId,
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

            if (characteristicId > 0)
                query = query.Where(x =>
                    x.CharacteristicDescriptions.Any(i => i.Characteristics.Id == characteristicId)).ToList();

            if (!string.IsNullOrEmpty(description))
                query = query.Where(x =>
                    x.CharacteristicDescriptions.Any(i => i.CharacteristicKeys.Description.ToLower().Contains(description.ToLower()))).ToList();

            return query;
        }

        public async Task<bool> Update(Product entity)
        {
            try
            {
                var product = new Product
                {
                    Id = entity.Id,
                    CategoryId = entity.CategoryId,
                    Description = entity.Description,
                    ManufacturerId = entity.ManufacturerId,
                    YearOfManufacture = entity.YearOfManufacture,
                    Model = entity.Model
                };

                var characteristicDescriptions = entity.CharacteristicDescriptions.ToList();

                _context.Update(product);
                _context.SaveChanges();

                var _result = await productItem.FindByProductIdDelete(entity.Id);

                foreach (var item in _result)
                {
                    _context.Remove(item);
                    _context.SaveChanges();
                }

                if (entity.CharacteristicDescriptions.Count > 0)
                {
                    foreach (var item in entity.CharacteristicDescriptions)
                    {
                        var characteristicDescription = new CharacteristicDescription
                        {
                            ProductId = product.Id,
                            CharacteristicId = item.CharacteristicId,
                            CharacteristicKeyId = item.CharacteristicKeyId
                        };

                        _context.Add(characteristicDescription);
                    }
                }

                await _context.SaveChangesAsync();

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