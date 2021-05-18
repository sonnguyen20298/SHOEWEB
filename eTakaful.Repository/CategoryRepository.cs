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
    public class CategoryReponsitory : BaseRepository<Category>, ICategoryReponsitory
    {

        public CategoryReponsitory(ApplicationDbContext dbContext) : base(dbContext)
        {
        }


        public async Task<ICollection<Category>> GetCategoryParrent()
        {
            return await DbContext.Categories.Where(c => c.ParentId == null).ToListAsync();
        }

        public async Task<IList<CollectionHomepage>> GetCollectionsHomepage()
        {
            var collections = await (from cate in DbContext.Categories
                               join ci in DbContext.CollectionImages
                               on cate.Id equals ci.CategoryId
                               where cate.IsCollection == true && cate.IsDeleted == false
                               select new CollectionHomepage
                               {
                                   Id = cate.Id,
                                   Name = cate.Name,
                                   UrlImage = ci.URL
                               }).ToListAsync();
            return collections;


        }
    }
}
