using Ecommerce.Service.Dto;
using EcommerceCommon.Infrastructure.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Service.ViewModels.Homepage
{
    public class HomepageModel
    {
        public IList<CollectionHomepage> CollectionHompageViewModel { get; set; }
        public List<ProductHomepage> ProductHomepage { get; set; }



    }
}
