using Ecommerce.Domain;
using Ecommerce.Domain.Models;
using Ecommerce.Repository.Interfaces;
using EcommerceCommon.Infrastructure.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
namespace Ecommerce.Repository
{
    public class ProductSizeRepository : BaseRepository<ProductSize>, IProductSizeRepository
    {
        public ProductSizeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<ProductSizeViewModel>> GetProductSizeByProductId(Guid ProductId)
        {
            var products = await (from ps in DbContext.ProductSizes
                            where ps.ProductId == ProductId
                            orderby ps.Size
                            select new ProductSizeViewModel
                            {
                                Id = ps.Id,
                                Size = ps.Size,
                                CountStock = ps.CountStock
                            }).ToListAsync();
            return products;
        }
    }

}
