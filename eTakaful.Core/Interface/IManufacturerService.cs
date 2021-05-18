using Ecommerce.Domain.Models;
using Ecommerce.Service.ViewModels.Homepage;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Service.Interface
{
    public interface IManufacturerService : IServices<Manufacturer>
    {
        Task<IList<ManufacturerHomepageViewModel>> GetManufacturerHomepage();
    }
}
