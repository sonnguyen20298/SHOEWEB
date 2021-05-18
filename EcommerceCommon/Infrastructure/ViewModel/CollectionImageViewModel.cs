using EcommerceCommon.Infrastructure.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceCommon.Infrastructure.ViewModel
{
    public class CollectionImageViewModel
    {
        public Guid Id { get; set; }

        public string CategoryName { get; set; }
        public string UrlImage { get; set; }

        public DateTime? CreatedDate { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public string UpdatedBy { get; set; }

        public bool? IsDeleted { get; set; }

        public Status Status { get; set; }

    }
}
