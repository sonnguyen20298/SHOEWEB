using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceCommon.Infrastructure.ViewModel
{
    public class ProductSizeViewModel
    {
        public Guid Id { get; set; }
        public int Size { get; set; }
        public int CountStock { get; set; }
    }
}
