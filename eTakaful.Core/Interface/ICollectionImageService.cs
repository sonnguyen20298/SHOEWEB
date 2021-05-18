using Ecommerce.Domain.Models;
using EcommerceCommon.Infrastructure.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Service.Interface
{
    public interface ICollectionImageService : IServices<CollectionImage>
    {
        Task<IList<CollectionImageViewModel>> GetCollectionImageList();
    }
}
