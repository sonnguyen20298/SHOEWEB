using Ecommerce.Domain;
using Ecommerce.Domain.Models;
using Ecommerce.Repository.Interfaces;
using EcommerceCommon.Infrastructure.ViewModel;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Repository
{
    public class CollectionImageRepository : BaseRepository<CollectionImage>, ICollectionImageRepository
    {
        public CollectionImageRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<IList<CollectionImageViewModel>> GetCollectionImageViewModel()
        {
            var collection = await (from ci in DbContext.CollectionImages
                                     join cate in DbContext.Categories
                                     on ci.CategoryId equals cate.Id
                                     where cate.IsCollection == true && cate.IsDeleted == false
                                     select new CollectionImageViewModel
                                     {
                                         CategoryName = cate.Name,
                                         UrlImage = ci.URL,
                                         CreatedDate = ci.CreatedDate,
                                         CreatedBy = ci.CreatedBy,
                                         UpdatedDate = ci.UpdatedDate,
                                         UpdatedBy = ci.UpdatedBy,
                                         IsDeleted = ci.IsDeleted,
                                     }).ToListAsync();
            return collection;


        }
    }
}
