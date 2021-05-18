using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Service.ViewModels.Homepage
{
    public class CategoryMenuHomepageViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid ParentId { get; set; }
    }
}
