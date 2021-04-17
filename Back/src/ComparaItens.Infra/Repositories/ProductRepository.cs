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

            //foreach (var item in entity.SpecificationItems)
            //{
            //    SpecificationItem specificationItem = new SpecificationItem();
            //    specificationItem.ProductId = product.Id;
            //    _context.Add(specificationItem);
            //}

            return (await _context.SaveChangesAsync()) > 0;
        }

        public async Task<IList<Product>> FindAll()
        {
            var _return =  await _context.Products.AsNoTracking()
                .Include(x => x.Category)
                .Include(x => x.Manufecturer)
                .ToListAsync();


            return _return;

        }

        public async Task<IList<Product>> FindByCategory(int category)
        {
            return null;
            //return await _context.Products.AsNoTracking()
            //                                  .Include(x => x.Manufecturer)
            //                                  .Include(x => x.Category)
            //                                  .Include(x => x.SpecificationItems)
            //                                  .Where(x => x.CategoryId == category && x.SpecificationItems.Any(s => s.ProductId == x.Id)).ToListAsync();
        }

        public async Task<Product> FindById(int id)
        {
            return null;

            //return await _context.Products.AsNoTracking()
            //                                  .Include(x => x.Manufecturer)
            //                                  .Include(x => x.Category)
            //                                  .Include( x=> x.SpecificationItems)
            //                                  .Where(x => x.Id == id && x.SpecificationItems.Any(s=>s.ProductId == x.Id )).FirstOrDefaultAsync();
        }

        public async Task<IList<SpecificationItem>> FindBySpecificationItem(int productId)
        {
            return await _context.SpecificationItems.AsNoTracking()
                                              .Where(x => x.ProductId == productId).ToListAsync();
        }

        public async Task<IList<Product>> FindBySpecificationItem(int categoryId, string description)
        {
            //return await _context.Products.AsNoTracking().Where(x => x.CategoryId == categoryId
            //                                                  && x.SpecificationItems.Any(s => s.Description.Contains(description))).ToListAsync();

            return null;
        }
    }
}