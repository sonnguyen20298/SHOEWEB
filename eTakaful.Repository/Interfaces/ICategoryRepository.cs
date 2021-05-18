using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Ecommerce.Domain.Models;
using EcommerceCommon.Infrastructure.ViewModel;

namespace Ecommerce.Repository.Interfaces
{
    public interface ICategoryReponsitory : IRepository<Category>
    {
       Task<ICollection<Category>> GetCategoryParrent();
       Task<IList<CollectionHomepage>> GetCollectionsHomepage();
        
    }
}
