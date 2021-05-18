using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecommerce.Domain;
using Ecommerce.Domain.Models;
using Ecommerce.Repository.Interfaces;
using EcommerceCommon.Infrastructure.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Repository
{
    public class ProductReponsitory : BaseRepository<Product>, IProductReponsitory
    {
        public ProductReponsitory(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public Task<List<ProductHomepage>> GetHotTrendProduct()
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductHomepage>> GetProductTopView()
        {
            var products = (from p in DbContext.Products
                            join pi in DbContext.ProductImages on p.Id equals pi.ProductId
                            where p.IsDeleted == false && pi.IsMainImage == true
                            orderby p.View descending

                            select new ProductHomepage
                            {
                                Id = p.Id,
                                Name = p.Name,
                                Price = p.Price,
                                UrlImage = pi.ImageLink,
                                PriceSale = p.DiscountPrice
                            }).ToListAsync();
            return products;
        }

        public Task<List<ProductListViewModel>> GetProductByCategoryLevel2(Guid CategoryID)
        {
            var product = (from p in DbContext.Products
                           join pi in DbContext.ProductImages on p.Id equals pi.ProductId
                           where p.IsDeleted == false && p.CategoryId == CategoryID && pi.IsMainImage== true
                           select new ProductListViewModel
                           {
                               Id = p.Id,
                               Name = p.Name,
                               Price = p.Price,
                               DiscountPrice = p.DiscountPrice,
                               UrlImage = pi.ImageLink
                           }).ToListAsync();
            return product;
        }

        public Task<List<ProductListViewModel>> GetProductByCategoryLevel1(Guid CategoryID)
        {
            var product = (from p in DbContext.Products
                           join c in DbContext.Categories on p.CategoryId equals c.Id
                           join pi in DbContext.ProductImages on p.Id equals pi.ProductId
                           where p.IsDeleted == false && c.ParentId == CategoryID && pi.IsMainImage == true
                           select new ProductListViewModel
                           {
                               Id = p.Id,
                               Name = p.Name,
                               Price = p.Price,
                               DiscountPrice = p.DiscountPrice,
                               UrlImage = pi.ImageLink
                           }).ToListAsync();
            return product;
        }


    }
}
